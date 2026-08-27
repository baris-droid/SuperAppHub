using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperApp.Core;    
using SuperApp.Core.UI; 

namespace SmartApp
{
    public partial class ucInputMaster : UserControl
    {
        private readonly IInputMasterBackend _inputBackend;
        private CancellationTokenSource? _cancellationTokenSource;
        private bool _isRunning = false;
        
        private readonly Button _focusSink;

        private enum KeyWaitTarget { None, Scroll, Volume }
        private KeyWaitTarget _waitTarget = KeyWaitTarget.None;

        public ucInputMaster()
        {
            ThemeManager.SetTheme(SettingsManager.Instance.Current.IsDarkMode);
            InitializeComponent();
            
            _focusSink = new Button
            {
                Location = new Point(-1000, -1000), // Ekranın tamamen dışına taşı
                Size = new Size(1, 1),              // Boyutunu minimumda tut
                TabStop = false,                    // Klavyedeki "Tab" tuşuyla yanlışlıkla odaklanılmasını engelle
                Text = string.Empty
            };
            this.Controls.Add(_focusSink);
            SetupFocusLossOnBackgroundClick(this);
            
            ThemeManager.ThemeChanged += (s, e) => ApplyTheme();
            ApplyTheme(); // Temayı uyguluyoruz

            _inputBackend = new InputMasterNativeWrapper();

            LoadUIFromSettings();

            btnToggleInput.Click -= btnToggleInput_Click;
            btnToggleInput.Click += btnToggleInput_Click;

            btnSetScrollKey.Click -= btnSetScrollKey_Click;
            btnSetScrollKey.Click += btnSetScrollKey_Click;

            btnSetVolumeKey.Click -= btnSetVolumeKey_Click;
            btnSetVolumeKey.Click += btnSetVolumeKey_Click;
            
            btnSetScrollKey.PreviewKeyDown -= AnyKeyButton_PreviewKeyDown;
            btnSetScrollKey.PreviewKeyDown += AnyKeyButton_PreviewKeyDown;

            btnSetVolumeKey.PreviewKeyDown -= AnyKeyButton_PreviewKeyDown;
            btnSetVolumeKey.PreviewKeyDown += AnyKeyButton_PreviewKeyDown;

            btnSetScrollKey.KeyDown -= AnyKeyButton_KeyDown;
            btnSetScrollKey.KeyDown += AnyKeyButton_KeyDown;

            btnSetVolumeKey.KeyDown -= AnyKeyButton_KeyDown;
            btnSetVolumeKey.KeyDown += AnyKeyButton_KeyDown;

            numScrollMult.ValueChanged -= UIElement_ValueChanged;
            numScrollMult.ValueChanged += UIElement_ValueChanged;

            numVolSens.ValueChanged -= UIElement_ValueChanged;
            numVolSens.ValueChanged += UIElement_ValueChanged;
        }

        private void ApplyTheme()
        {
            // Ana arka plan
            this.BackColor = ThemeManager.ContentBackground;

            // Kart Panelleri
            pnlControl.BackColor = ThemeManager.SidebarBackground;
            pnlScrollCard.BackColor = ThemeManager.SidebarBackground;
            pnlVolumeCard.BackColor = ThemeManager.SidebarBackground;

            // Başlıklar
            lblPageTitle.ForeColor = ThemeManager.TextPrimary;
            lblScrollTitle.ForeColor = ThemeManager.TextPrimary;
            lblVolumeTitle.ForeColor = ThemeManager.TextPrimary;
            lblStatus.ForeColor = ThemeManager.TextSecondary;

            // Etiketler
            label1.ForeColor = ThemeManager.TextSecondary;
            label2.ForeColor = ThemeManager.TextSecondary;

            // Sayı Seçiciler (NumericUpDown)
            numScrollMult.BackColor = ThemeManager.ContentBackground;
            numScrollMult.ForeColor = ThemeManager.TextPrimary;
            numVolSens.BackColor = ThemeManager.ContentBackground;
            numVolSens.ForeColor = ThemeManager.TextPrimary;

            // Tuş Atama Butonları
            btnSetScrollKey.BackColor = ThemeManager.ContentBackground;
            btnSetScrollKey.ForeColor = ThemeManager.TextPrimary;
            btnSetScrollKey.FlatAppearance.BorderColor = ThemeManager.ButtonDown;

            btnSetVolumeKey.BackColor = ThemeManager.ContentBackground;
            btnSetVolumeKey.ForeColor = ThemeManager.TextPrimary;
            btnSetVolumeKey.FlatAppearance.BorderColor = ThemeManager.ButtonDown;
            
            // Ana Kontrol Butonu
            btnToggleInput.BackColor = ThemeManager.AccentColor;
            
            ThemeManager.FormatControls(this.Controls);
        }
        
        private void SetupFocusLossOnBackgroundClick(Control container)
        {
            if (container is not TextBox and not ComboBox and not NumericUpDown and not Button)
            {
                container.MouseDown -= OnBackgroundMouseDown; 
                container.MouseDown += OnBackgroundMouseDown; 
            }

            foreach (Control child in container.Controls)
            {
                SetupFocusLossOnBackgroundClick(child);
            }
        }
        
        private void OnBackgroundMouseDown(object? sender, MouseEventArgs e)
        {
            _focusSink.Focus();
        }

        private void LoadUIFromSettings()
        {
            var settings = SettingsManager.Instance.Current;

            numScrollMult.Value = Math.Clamp(settings.InputScrollMultiplier, numScrollMult.Minimum, numScrollMult.Maximum);
            numVolSens.Value = Math.Clamp(settings.InputVolumeSensitivity, numVolSens.Minimum, numVolSens.Maximum);

            btnSetScrollKey.Text = $"Kaydırma Tuşu: {(Keys)settings.InputScrollKey}";
            btnSetVolumeKey.Text = $"Ses Tuşu: {(Keys)settings.InputVolumeKey}";

            _inputBackend.SetInputSettings((int)numScrollMult.Value, (int)numVolSens.Value);
            _inputBackend.SetInputHotkeys(settings.InputScrollKey, settings.InputVolumeKey);
        }

        private void UIElement_ValueChanged(object? sender, EventArgs e)
        {
            var settings = SettingsManager.Instance.Current;
            settings.InputScrollMultiplier = (int)numScrollMult.Value;
            settings.InputVolumeSensitivity = (int)numVolSens.Value;

            SettingsManager.Instance.Save();
            _inputBackend.SetInputSettings(settings.InputScrollMultiplier, settings.InputVolumeSensitivity);
        }

        private void btnSetScrollKey_Click(object? sender, EventArgs e)
        {
            PrepareKeyListening(KeyWaitTarget.Scroll, btnSetScrollKey);
        }

        private void btnSetVolumeKey_Click(object? sender, EventArgs e)
        {
            PrepareKeyListening(KeyWaitTarget.Volume, btnSetVolumeKey);
        }

        private void PrepareKeyListening(KeyWaitTarget target, Button activeBtn)
        {
            _waitTarget = target;
            activeBtn.Text = "Tuşa Basın... (İptal: ESC)";
            activeBtn.BackColor = ThemeManager.ButtonDown; // Dinlerken daha koyu bir renk yap
            activeBtn.Focus();
        }

        // Yön tuşları veya Tab dahil her şeyi "Girdi" olarak kabul et.
        private void AnyKeyButton_PreviewKeyDown(object? sender, PreviewKeyDownEventArgs e)
        {
            if (_waitTarget != KeyWaitTarget.None)
            {
                e.IsInputKey = true;
            }
        }

        private void AnyKeyButton_KeyDown(object? sender, KeyEventArgs e)
        {
            if (_waitTarget == KeyWaitTarget.None) return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Escape)
            {
                _waitTarget = KeyWaitTarget.None;
                btnSetScrollKey.BackColor = ThemeManager.ContentBackground; // Rengi eski haline çevir
                btnSetVolumeKey.BackColor = ThemeManager.ContentBackground;
                LoadUIFromSettings();
                return;
            }

            var settings = SettingsManager.Instance.Current;

            if (_waitTarget == KeyWaitTarget.Scroll)
            {
                settings.InputScrollKey = (int)e.KeyCode;
                btnSetScrollKey.BackColor = ThemeManager.ContentBackground; // Rengi eski haline çevir
            }
            else if (_waitTarget == KeyWaitTarget.Volume)
            {
                settings.InputVolumeKey = (int)e.KeyCode;
                btnSetVolumeKey.BackColor = ThemeManager.ContentBackground; // Rengi eski haline çevir
            }

            SettingsManager.Instance.Save();
            _inputBackend.SetInputHotkeys(settings.InputScrollKey, settings.InputVolumeKey);

            _waitTarget = KeyWaitTarget.None;
            LoadUIFromSettings();
        }

        private async void btnToggleInput_Click(object? sender, EventArgs e)
        {
            if (_isRunning)
            {
                StopInputMaster();
            }
            else
            {
                await StartInputMasterAsync();
            }
        }

        private async Task StartInputMasterAsync()
        {
            _isRunning = true;
            btnToggleInput.Text = "Kısayolları Durdur";
            btnToggleInput.BackColor = Color.FromArgb(239, 68, 68); // Modern Kırmızı (Red-500)
            UpdateStatusLabel("Durum: Çalışıyor (Bekleniyor...)", Color.FromArgb(16, 185, 129)); // Modern Yeşil (Emerald-500)

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                while (_isRunning && !token.IsCancellationRequested)
                {
                    _inputBackend.ProcessInputTick();
                    await Task.Delay(10, token); // 10ms CPU'yu boğmamak için ideal
                }
            }
            catch (TaskCanceledException)
            {
                UpdateStatusLabel("Durum: Durduruldu.", ThemeManager.TextSecondary);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kısayol izleyicide beklenmeyen hata: {ex.Message}", "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopInputMaster();
            }
        }

        private void StopInputMaster()
        {
            _isRunning = false;
            _cancellationTokenSource?.Cancel();

            btnToggleInput.Text = "Kısayolları Başlat";
            btnToggleInput.BackColor = ThemeManager.AccentColor; // Maviye (Accent) dön
            UpdateStatusLabel("Durum: Durduruldu.", ThemeManager.TextSecondary);
        }

        private void UpdateStatusLabel(string text, Color color)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.Invoke(new Action(() =>
                {
                    lblStatus.Text = text;
                    lblStatus.ForeColor = color;
                }));
            }
        }

        public void Cleanup()
        {
            StopInputMaster();
            _cancellationTokenSource?.Dispose();
        }
    }
}