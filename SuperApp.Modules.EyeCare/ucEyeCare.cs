using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperApp.Core; 
using SuperApp.Core.UI; 

namespace SmartApp
{
    public partial class ucEyeCare : UserControl
    {
        private readonly IEyeCareBackend _eyeBackend;
        private CancellationTokenSource? _cancellationTokenSource;
        private bool _isRunning = false;

        // Bildirim formunu bir kez oluşturuyoruz
        private frmEyeNotification? _notificationForm;

        public ucEyeCare()
        {
            ThemeManager.SetTheme(SettingsManager.Instance.Current.IsDarkMode);
            InitializeComponent();
            ThemeManager.ThemeChanged += (s, e) => ApplyTheme();
            ApplyTheme(); // Tema sistemini bu arayüze uyguluyoruz

            _eyeBackend = new EyeCareNativeWrapper();

            LoadUIFromSettings();

            btnToggleEyeCare.Click -= btnToggleEyeCare_Click;
            btnToggleEyeCare.Click += btnToggleEyeCare_Click;

            numWorkMin.ValueChanged -= UIElement_ValueChanged;
            numWorkMin.ValueChanged += UIElement_ValueChanged;

            numRestSec.ValueChanged -= UIElement_ValueChanged;
            numRestSec.ValueChanged += UIElement_ValueChanged;

            cmbLocation.SelectedIndexChanged -= UIElement_ValueChanged;
            cmbLocation.SelectedIndexChanged += UIElement_ValueChanged;

            trkOpacity.Scroll -= UIElement_ValueChanged;
            trkOpacity.Scroll += UIElement_ValueChanged;
        }

        private void ApplyTheme()
        {
            // Ana arka plan
            this.BackColor = ThemeManager.ContentBackground;

            // Kart Panelleri
            pnlTimingCard.BackColor = ThemeManager.SidebarBackground;
            pnlVisualCard.BackColor = ThemeManager.SidebarBackground;

            // Başlıklar
            lblPageTitle.ForeColor = ThemeManager.TextPrimary;
            lblTimingTitle.ForeColor = ThemeManager.TextPrimary;
            lblVisualTitle.ForeColor = ThemeManager.TextPrimary;

            // Etiketler
            label1.ForeColor = ThemeManager.TextSecondary;
            label2.ForeColor = ThemeManager.TextSecondary;
            label3.ForeColor = ThemeManager.TextSecondary;
            label4.ForeColor = ThemeManager.TextSecondary;

            // Sayı seçiciler (NumericUpDown)
            numWorkMin.BackColor = ThemeManager.ContentBackground;
            numWorkMin.ForeColor = ThemeManager.TextPrimary;
            numRestSec.BackColor = ThemeManager.ContentBackground;
            numRestSec.ForeColor = ThemeManager.TextPrimary;

            // ComboBox
            cmbLocation.BackColor = ThemeManager.ContentBackground;
            cmbLocation.ForeColor = ThemeManager.TextPrimary;
            
            ThemeManager.FormatControls(this.Controls);
        }

        private void LoadUIFromSettings()
        {
            var settings = SettingsManager.Instance.Current;
            numWorkMin.Value = Math.Clamp(settings.EyeCareWorkMinutes, numWorkMin.Minimum, numWorkMin.Maximum);
            numRestSec.Value = Math.Clamp(settings.EyeCareRestSeconds, numRestSec.Minimum, numRestSec.Maximum);

            trkOpacity.Value = Math.Clamp(settings.EyeCareOpacity, trkOpacity.Minimum, trkOpacity.Maximum);

            if (settings.EyeCareNotificationLocation >= 0 && settings.EyeCareNotificationLocation < cmbLocation.Items.Count)
                cmbLocation.SelectedIndex = settings.EyeCareNotificationLocation;
            else if (cmbLocation.Items.Count > 0)
                cmbLocation.SelectedIndex = 0;
        }

        private void UIElement_ValueChanged(object? sender, EventArgs e)
        {
            var settings = SettingsManager.Instance.Current;
            settings.EyeCareWorkMinutes = (int)numWorkMin.Value;
            settings.EyeCareRestSeconds = (int)numRestSec.Value;
            settings.EyeCareNotificationLocation = cmbLocation.SelectedIndex;

            settings.EyeCareOpacity = trkOpacity.Value;

            SettingsManager.Instance.Save();

            // Eğer sistem çalışıyorsa, yeni ayarları C DLL'ine anında gönder
            if (_isRunning)
            {
                _eyeBackend.StartEyeCare(settings.EyeCareWorkMinutes, settings.EyeCareRestSeconds);
            }

            // Eğer bildirim formu o an ekrandaysa, şeffaflığı canlı canlı (Real-time) değiştir
            if (_notificationForm != null && !_notificationForm.IsDisposed)
            {
                _notificationForm.SetOpacity(settings.EyeCareOpacity);
            }
        }

        private async void btnToggleEyeCare_Click(object? sender, EventArgs e)
        {
            if (_isRunning) StopEyeCare();
            else await StartEyeCareAsync();
        }

        private async Task StartEyeCareAsync()
        {
            _isRunning = true;
            btnToggleEyeCare.Text = "Takibi Durdur";
            btnToggleEyeCare.BackColor = Color.FromArgb(239, 68, 68); // Durdururken Kırmızı (Red-500)
            UpdateStatusLabel("Durum: Takip Ediliyor", Color.FromArgb(16, 185, 129)); // Yeşil Status (Emerald-500)

            // Bildirim formu yoksa oluştur
            if (_notificationForm == null || _notificationForm.IsDisposed)
            {
                _notificationForm = new frmEyeNotification();
            }

            var settings = SettingsManager.Instance.Current;
            _eyeBackend.StartEyeCare(settings.EyeCareWorkMinutes, settings.EyeCareRestSeconds);

            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                while (_isRunning && !token.IsCancellationRequested)
                {
                    int state = _eyeBackend.GetEyeCareState();
                    int remaining = _eyeBackend.GetRemainingSeconds();

                    if (state == 1) // ÇALIŞMA MODU
                    {
                        HideNotification();
                        UpdateStatusLabel($"Odaklanıldı. Kalan: {remaining} sn", ThemeManager.AccentColor); // Mavi (Accent) Status
                    }
                    else if (state == 2) // DİNLENME MODU
                    {
                        ShowNotification(settings.EyeCareNotificationLocation, remaining);
                        UpdateStatusLabel("Gözler Dinlendiriliyor!", Color.FromArgb(245, 158, 11)); // Turuncu (Amber-500) Status
                    }

                    await Task.Delay(500, token); // Saniyede 2 kez kontrol et
                }
            }
            catch (TaskCanceledException) { }
            finally
            {
                HideNotification(); // Döngü kırılırsa bildirimi kesin kapat
            }
        }

        private void StopEyeCare()
        {
            _isRunning = false;
            _cancellationTokenSource?.Cancel();
            _eyeBackend.StopEyeCare();

            btnToggleEyeCare.Text = "Takibi Başlat";
            btnToggleEyeCare.BackColor = ThemeManager.AccentColor; // Maviye (Accent) dön
            UpdateStatusLabel("Durum: Durduruldu", ThemeManager.TextSecondary); // Pasif Gri Status
            HideNotification();
        }

        private void ShowNotification(int locationMode, int remainingSec)
        {
            if (_notificationForm == null || _notificationForm.IsDisposed) return;

            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.Invoke((MethodInvoker)delegate
                {

                    _notificationForm.SetOpacity(SettingsManager.Instance.Current.EyeCareOpacity);

                    if (!_notificationForm.Visible)
                    {
                        _notificationForm.SetLocation(locationMode);
                        _notificationForm.Show(); // ShowDialog yapmıyoruz, programı kilitlemez!
                    }
                    _notificationForm.UpdateMessage(remainingSec);
                });
            }
        }

        private void HideNotification()
        {
            if (_notificationForm != null && _notificationForm.Visible)
            {
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    this.Invoke((MethodInvoker)delegate { _notificationForm.Hide(); });
                }
            }
        }

        private void UpdateStatusLabel(string text, Color color)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.Invoke(new Action(() => { lblStatus.Text = text; lblStatus.ForeColor = color; }));
            }
        }

        public void Cleanup()
        {
            StopEyeCare();
            _cancellationTokenSource?.Dispose();
            _notificationForm?.Dispose(); // Bellek sızıntısını önlemek amacıyla
        }
    }
}