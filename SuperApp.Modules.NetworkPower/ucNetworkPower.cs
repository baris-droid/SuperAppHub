using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperApp.Core;   
using SuperApp.Core.UI;

namespace SmartApp
{
    public partial class ucNetworkPower : UserControl
    {
        private readonly INetworkPowerBackend _networkBackend;
        private CancellationTokenSource? _cancellationTokenSource;
        private bool _isMonitoring = false;

        public ucNetworkPower()
        {
            ThemeManager.SetTheme(SettingsManager.Instance.Current.IsDarkMode);
            InitializeComponent();
            ThemeManager.ThemeChanged += (s, e) => ApplyTheme();
            ApplyTheme(); // Temayı uyguluyoruz
            _networkBackend = new NetworkPowerNativeWrapper();

            // Arayüzü bellekteki ayarlarla dolduruyoruz
            LoadUIFromSettings();
            
            btnToggleMonitor.Click -= btnToggleMonitor_Click;
            btnToggleMonitor.Click += btnToggleMonitor_Click;

            numThreshold.ValueChanged -= UIElement_ValueChanged;
            numThreshold.ValueChanged += UIElement_ValueChanged;

            numWaitTime.ValueChanged -= UIElement_ValueChanged;
            numWaitTime.ValueChanged += UIElement_ValueChanged;

            cmbActionType.SelectedIndexChanged -= UIElement_ValueChanged;
            cmbActionType.SelectedIndexChanged += UIElement_ValueChanged;
        }

        private void ApplyTheme()
        {
            // Ana arka plan
            this.BackColor = ThemeManager.ContentBackground;

            // Kart Paneli
            pnlCard.BackColor = ThemeManager.SidebarBackground;

            // Uyarı (Alert) Kartı Tasarımı (Kırmızı Alert Box Standardı)
            pnlAlert.BackColor = Color.FromArgb(254, 242, 242); // Açık kırmızımsı arka plan
            lblAlertIcon.ForeColor = Color.FromArgb(220, 38, 38); // Kırmızı ikon
            label4.ForeColor = Color.FromArgb(153, 27, 27); // Koyu kırmızı yazı

            // Başlıklar
            lblPageTitle.ForeColor = ThemeManager.TextPrimary;
            lblCardTitle.ForeColor = ThemeManager.TextPrimary;
            lblStatus.ForeColor = ThemeManager.TextSecondary;

            // Etiketler
            label1.ForeColor = ThemeManager.TextSecondary;
            label2.ForeColor = ThemeManager.TextSecondary;
            label3.ForeColor = ThemeManager.TextSecondary;

            // Girdi Elemanları (TextBox / Numeric / Combo)
            numThreshold.BackColor = ThemeManager.ContentBackground;
            numThreshold.ForeColor = ThemeManager.TextPrimary;
            numWaitTime.BackColor = ThemeManager.ContentBackground;
            numWaitTime.ForeColor = ThemeManager.TextPrimary;
            cmbActionType.BackColor = ThemeManager.ContentBackground;
            cmbActionType.ForeColor = ThemeManager.TextPrimary;

            // Buton (Başlangıç durumu)
            btnToggleMonitor.BackColor = ThemeManager.AccentColor;
            
            ThemeManager.FormatControls(this.Controls);
        }

        // --- ARAYÜZ YÜKLEME ---
        private void LoadUIFromSettings()
        {
            var settings = SettingsManager.Instance.Current;

            // Math.Clamp: JSON dosyasındaki değer arayüzdeki Min-Max limitlerinin dışındaysa uygulamanın çökmesini engeller.
            numThreshold.Value = Math.Clamp((decimal)settings.NetworkThresholdKbps, numThreshold.Minimum, numThreshold.Maximum);
            numWaitTime.Value = Math.Clamp(settings.NetworkWaitTimeSeconds, numWaitTime.Minimum, numWaitTime.Maximum);

            // ComboBox'ta geçerli bir index yoksa (ilk açılış) varsayılan olarak 0. (Uyku Modu) elemanı seç
            if (settings.NetworkActionType >= 0 && settings.NetworkActionType < cmbActionType.Items.Count)
            {
                cmbActionType.SelectedIndex = settings.NetworkActionType;
            }
            else if (cmbActionType.Items.Count > 0)
            {
                cmbActionType.SelectedIndex = 0;
            }
        }

        // --- ORTAK KAYIT METODU (DRY Prensibi) ---
        private void UpdateAndSaveSettings()
        {
            var settings = SettingsManager.Instance.Current;

            // Arayüzdeki güncel verileri bellekteki modele yansıt
            settings.NetworkThresholdKbps = (double)numThreshold.Value;
            settings.NetworkWaitTimeSeconds = (int)numWaitTime.Value;
            settings.NetworkActionType = cmbActionType.SelectedIndex;

            // Modeli diske (ayarlar.json) yazdır
            SettingsManager.Instance.Save();
        }

        // Kullanıcı Hız, Süre veya İşlem Türünü değiştirdiği an burası tetiklenir
        private void UIElement_ValueChanged(object? sender, EventArgs e)
        {
            UpdateAndSaveSettings();
        }

        // --- İZLEME MANTIĞI ---
        private async void btnToggleMonitor_Click(object? sender, EventArgs e)
        {
            if (_isMonitoring)
            {
                StopMonitoring();
            }
            else
            {
                await StartMonitoringAsync();
            }
        }

        private async Task StartMonitoringAsync()
        {
            _isMonitoring = true;
            btnToggleMonitor.Text = "İzlemeyi Durdur";
            btnToggleMonitor.BackColor = Color.FromArgb(239, 68, 68); // İptal rengi kırmızı (Red-500)
            UpdateStatusLabel("Durum: İzleniyor...", Color.FromArgb(16, 185, 129)); // Yeşil Status (Emerald-500)

            // Arka plan görevini anında iptal edebilmek için token oluşturuyoruz
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            var settings = SettingsManager.Instance.Current;
            double thresholdKbps = settings.NetworkThresholdKbps;
            int waitTimeSeconds = settings.NetworkWaitTimeSeconds;
            int idleCounter = 0;

            try
            {
                while (_isMonitoring && !token.IsCancellationRequested)
                {
                    ulong initialBytes = _networkBackend.GetTotalBytesReceived();

                    // UI thread'ini kilitlemeden asenkron bekleme
                    await Task.Delay(1000, token);

                    ulong currentBytes = _networkBackend.GetTotalBytesReceived();
                    double currentSpeedKbps = (currentBytes - initialBytes) / 1024.0;

                    UpdateStatusLabel($"Anlık Hız: {currentSpeedKbps:F2} KB/s", ThemeManager.AccentColor);

                    if (currentSpeedKbps < thresholdKbps)
                    {
                        idleCounter++;
                        UpdateStatusLabel($"Düşük Hız! Kalan Süre: {waitTimeSeconds - idleCounter} sn", Color.FromArgb(245, 158, 11)); // Turuncu/Sarı (Amber-500)

                        if (idleCounter >= waitTimeSeconds)
                        {
                            UpdateStatusLabel("İşlem tamamlandı, sistem tetikleniyor...", Color.FromArgb(239, 68, 68)); // Kırmızı
                            ExecutePowerAction(settings.NetworkActionType);
                            StopMonitoring();
                            break;
                        }
                    }
                    else
                    {
                        if (idleCounter > 0)
                        {
                            idleCounter = 0;
                            UpdateStatusLabel("Hız yükseldi, sayaç sıfırlandı.", Color.FromArgb(16, 185, 129)); // Yeşil (Emerald-500)
                        }
                    }
                }
            }
            catch (TaskCanceledException)
            {
                // Kullanıcı butona basarak izlemeyi durdurduğunda uygulama çökmek yerine buraya düşer
                UpdateStatusLabel("Durum: İzleme iptal edildi.", ThemeManager.TextSecondary);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İzleme sırasında hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopMonitoring();
            }
        }

        private void ExecutePowerAction(int actionType)
        {
            // 0: Uyku Modu (Sleep), 1: Kapatma (Shutdown)
            if (actionType == 0)
                _networkBackend.SuspendSystem();
            else if (actionType == 1)
                _networkBackend.ShutdownSystem();
        }

        private void StopMonitoring()
        {
            _isMonitoring = false;
            _cancellationTokenSource?.Cancel(); // Beklemeyi (Task.Delay) anında keser

            btnToggleMonitor.Text = "İzlemeyi Başlat";
            btnToggleMonitor.BackColor = ThemeManager.AccentColor; // Orijinal mavi renge dön
            UpdateStatusLabel("Durum: Durduruldu.", ThemeManager.TextSecondary);
        }

        // Thread Safe Arayüz Güncellemesi
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

        // --- BELLEK TEMİZLİĞİ ---
        public void Cleanup()
        {
            UpdateAndSaveSettings(); // Ana form kapanırken son bir kez kaydet
            StopMonitoring();        // Açık kalmış olabilecek izlemeyi güvenlice durdur
            _cancellationTokenSource?.Dispose(); // Bellek sızıntısını (Memory Leak) önle
        }
    }
}