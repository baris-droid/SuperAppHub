using System;
using System.Drawing;
using System.Windows.Forms;
using SuperApp.Core;
using SuperApp.Core.UI; // ThemeManager için

namespace SmartApp
{
    public partial class ucDiscordRPC : UserControl
    {
        private readonly IDiscordBackend _discordBackend;

        public ucDiscordRPC()
        {
            ThemeManager.SetTheme(SettingsManager.Instance.Current.IsDarkMode);
            InitializeComponent();
            ThemeManager.ThemeChanged += (s, e) => ApplyTheme();
            ApplyTheme(); // Tema sistemimizi bu sayfaya da uyguluyoruz
            
            btnConnect.Click += btnConnect_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDisconnect.Click += btnDisconnect_Click;

            _discordBackend = new DiscordNativeWrapper();

            // Arayüzü yüklerken doğrudan SettingsManager üzerinden bellekteki güncel kopyayı okuyoruz
            LoadUIFromSettings();
        }
        
        private void ApplyTheme()
        {
            // Arka plan ve kart renkleri
            this.BackColor = ThemeManager.ContentBackground;
            pnlCard.BackColor = ThemeManager.SidebarBackground;

            // Başlıklar ve Etiketler
            lblTitle.ForeColor = ThemeManager.TextPrimary;
            lblClientId.ForeColor = ThemeManager.TextPrimary;
            lblImageLink.ForeColor = ThemeManager.TextPrimary;
            lblDetails.ForeColor = ThemeManager.TextPrimary;
            lblState.ForeColor = ThemeManager.TextPrimary;
            
            // Bilgi yazısı
            label1.ForeColor = ThemeManager.TextSecondary;

            // Metin kutularının (TextBox) temaya uyumu
            var textboxes = new[] { txtClientId, txtImageLink, txtDetails, txtState };
            foreach (var txt in textboxes)
            {
                txt.BackColor = ThemeManager.ContentBackground; // Kutu içini arkaplanla aynı yap
                txt.ForeColor = ThemeManager.TextPrimary;
                txt.BorderStyle = BorderStyle.FixedSingle;
            }
            
            ThemeManager.FormatControls(this.Controls);
        }

        // --- ARAYÜZ YÜKLEME ---
        private void LoadUIFromSettings()
        {
            // Singleton mimarisinden mevcut ayarları alıyoruz
            var settings = SettingsManager.Instance.Current;

            txtClientId.Text = settings.ClientId;
            txtDetails.Text = settings.Details;
            txtState.Text = settings.State;
            txtImageLink.Text = settings.ImageLink;
        }

        // --- BUTON OLAYLARI ---
        private void btnConnect_Click(object? sender, EventArgs e)
        {
            string clientId = txtClientId.Text.Trim();

            // Boş bir ID ile bağlanmaya çalışmayı engelliyoruz
            if (string.IsNullOrEmpty(clientId))
            {
                MessageBox.Show("Lütfen geçerli bir Client ID girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_discordBackend.Connect(clientId))
            {
                lblStatus.Text = "Durum: Bağlanıldı!";
                lblStatus.ForeColor = Color.FromArgb(16, 185, 129); // Modern Yeşil (Tailwind Emerald-500)

                // Bağlantı başarılıysa arayüz kontrollerini duruma uygun hale getir
                btnConnect.Enabled = false;
                txtClientId.Enabled = false;
                btnDisconnect.Enabled = true;

                // Yeni girilen değerleri belleğe ve diske kaydet
                UpdateAndSaveSettings();
            }
            else
            {
                MessageBox.Show("Discord'a bağlanılamadı. Uygulamanın açık olduğundan ve Client ID'nin doğruluğundan emin olun.", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            // Eğer bağlantı henüz kurulmadıysa (Connect butonu aktifse) güncelleme yapmayı engelle
            if (btnConnect.Enabled) return;

            _discordBackend.Update(txtDetails.Text, txtState.Text, txtImageLink.Text);

            // Güncellenen değerleri kaydet
            UpdateAndSaveSettings();
        }

        private void btnDisconnect_Click(object? sender, EventArgs e)
        {
            _discordBackend.Disconnect();

            lblStatus.Text = "Durum: Bağlantı Kesildi.";
            lblStatus.ForeColor = Color.FromArgb(239, 68, 68); // Modern Kırmızı (Tailwind Red-500)

            // Arayüz kontrollerini başlangıç durumuna (bağlantıya hazır) geri getir
            btnConnect.Enabled = true;
            txtClientId.Enabled = true;
            btnDisconnect.Enabled = false;
        }

        // --- ORTAK KAYIT METODU (DRY Prensibi) ---
        // Her işlemde aynı atamaları yazmamak için ortak bir metot oluşturduk.
        private void UpdateAndSaveSettings()
        {
            var settings = SettingsManager.Instance.Current;

            // Arayüzdeki güncel verileri bellekteki modele yansıt
            settings.ClientId = txtClientId.Text.Trim();
            settings.Details = txtDetails.Text;
            settings.State = txtState.Text;
            settings.ImageLink = txtImageLink.Text;

            // Modeli diske yazdır
            SettingsManager.Instance.Save();
        }

        // --- BELLEK TEMİZLİĞİ ---
        public void Cleanup()
        {
            // Uygulama kapanırken son durumu garanti altına almak için diske yaz
            UpdateAndSaveSettings();

            // Arkada çalışan Discord native wrapper'ını temizle (Memory Leak önleme)
            _discordBackend?.Dispose();
        }
    }
}