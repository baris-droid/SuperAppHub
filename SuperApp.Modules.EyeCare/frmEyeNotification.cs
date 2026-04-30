using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartApp
{
    public partial class frmEyeNotification : Form
    {
        public frmEyeNotification()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false; // Görev çubuğunda simge çıkmasın
            this.TopMost = true; // Her zaman en üstte olsun
            this.BackColor = Color.Black;
            this.Opacity = 0.85; // Varsayılan %85 şeffaflık (Daha sonra Settings'den güncellenecek)
            this.Size = new Size(450, 150); // Net bir boyut atıyoruz

            // ÇOK KRİTİK: Manuel lokasyon ayarının çalışması için Windows'un varsayılanını kapatıyoruz!
            this.StartPosition = FormStartPosition.Manual;

            // 2. İÇERİK (LABEL) AYARLARI
            lblMessage.ForeColor = Color.White;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMessage.Dock = DockStyle.Fill; // Yazının formu uçtan uca kaplamasını sağlar
            lblMessage.TextAlign = ContentAlignment.MiddleCenter; // Yazıyı tam ortaya hizalar
        }

        // --- HAYALET PENCERE (CLICK-THROUGH) MİMARİSİ ---
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80000;   // WS_EX_LAYERED (Şeffaflık render'ı için zorunlu)
                cp.ExStyle |= 0x20;      // WS_EX_TRANSPARENT (Fare tıklamaları içinden geçer, alttaki oyuna gider)
                cp.ExStyle |= 0x08000000;// WS_EX_NOACTIVATE (Pencere aktifleşmez)
                return cp;
            }
        }

        // Form gösterilirken Windows'un odağı (Focus) bu forma kaydırmasını kesin olarak engeller.
        // Özellikle tam ekran oyunlarda alt-tab atılmasını önler.
        protected override bool ShowWithoutActivation => true;

        // --- LOKASYON HESAPLAMA ---
        public void SetLocation(int locationMode)
        {
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            if (locationMode == 0) // Ekran Ortası
            {
                this.Left = (workingArea.Width - this.Width) / 2;
                this.Top = (workingArea.Height - this.Height) / 2;
            }
            else // Sağ Alt Köşe
            {
                this.Left = workingArea.Right - this.Width - 20;
                this.Top = workingArea.Bottom - this.Height - 20;
            }
        }

        // --- ARAYÜZ GÜNCELLEME ---
        public void UpdateMessage(int remainingSeconds)
        {
            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lblMessage.Text = $"GÖZLERİNİ DİNLENDİR!\nKalan Süre: {remainingSeconds} sn\nUzağa bak (6 Metre)";
                });
            }
        }

        // Formun opaklığını anlık olarak ayarlar (Yüzdelik değeri 0.0 - 1.0 arasına çevirir)
        public void SetOpacity(int opacityPercentage)
        {
            // Örn: 85 geldiğinde 85 / 100.0 = 0.85 yapar
            this.Opacity = opacityPercentage / 100.0;
        }
    }
}