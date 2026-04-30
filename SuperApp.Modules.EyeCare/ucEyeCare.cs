using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperApp.Core;

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
            InitializeComponent();
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
            UpdateStatusLabel("Durum: Takip Ediliyor", Color.Green);

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
                        UpdateStatusLabel($"Odaklanıldı. Kalan: {remaining} sn", Color.Blue);
                    }
                    else if (state == 2) // DİNLENME MODU
                    {
                        ShowNotification(settings.EyeCareNotificationLocation, remaining);
                        UpdateStatusLabel("Gözler Dinlendiriliyor!", Color.DarkOrange);
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
            UpdateStatusLabel("Durum: Durduruldu", Color.Black);
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