using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperApp.Core;

namespace SmartApp
{
    public partial class ucInputMaster : UserControl
    {
        private readonly IInputMasterBackend _inputBackend;
        private CancellationTokenSource? _cancellationTokenSource;
        private bool _isRunning = false;

        private enum KeyWaitTarget { None, Scroll, Volume }
        private KeyWaitTarget _waitTarget = KeyWaitTarget.None;

        public ucInputMaster()
        {
            InitializeComponent();

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
            activeBtn.Focus();
        }

        // Yön tuşları veya Tab dahil her şeyi "Girdi" olarak kabul et.
        // Bu sayede form odağı başka yere kaymaz ve tuş yutulmaz.
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
                LoadUIFromSettings();
                return;
            }

            var settings = SettingsManager.Instance.Current;

            // Kullanıcı Alt, Ctrl veya Shift gibi sadece değiştirici (modifier) tuşlara basarsa bile onu ana
            // kısayol olarak kaydedebilsin diye doğrudan e.KeyCode'u alıyoruz.
            if (_waitTarget == KeyWaitTarget.Scroll)
            {
                settings.InputScrollKey = (int)e.KeyCode;
            }
            else if (_waitTarget == KeyWaitTarget.Volume)
            {
                settings.InputVolumeKey = (int)e.KeyCode;
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
            UpdateStatusLabel("Durum: Çalışıyor (Bekleniyor...)", Color.Green);

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                while (_isRunning && !token.IsCancellationRequested)
                {
                    _inputBackend.ProcessInputTick();
                    await Task.Delay(10, token);
                }
            }
            catch (TaskCanceledException)
            {
                UpdateStatusLabel("Durum: Durduruldu.", Color.Black);
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
            UpdateStatusLabel("Durum: Durduruldu.", Color.Black);
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