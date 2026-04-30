using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SuperApp.Core;    
using SuperApp.Core.UI; 

namespace SmartApp
{
    public partial class ucMicController : UserControl
    {
        private readonly IMicBackend _micBackend;
        private const int HOTKEY_ID = 9000;

        // --- WINDOWS API KÜTÜPHANELERİ ---
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // --- HAYALET PENCERE MİMARİSİ ---
        private class HotkeyListener : NativeWindow, IDisposable
        {
            public event Action? OnHotkeyPressed;
            private const int WM_HOTKEY = 0x0312;

            public HotkeyListener()
            {
                this.CreateHandle(new CreateParams());
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == WM_HOTKEY)
                {
                    OnHotkeyPressed?.Invoke();
                }
                base.WndProc(ref m);
            }

            public void Dispose()
            {
                if (this.Handle != IntPtr.Zero)
                {
                    this.DestroyHandle();
                }
                GC.SuppressFinalize(this);
            }
        }

        private HotkeyListener _hotkeyListener;
        private Keys _currentKeyCode = Keys.M;
        private int _currentModifiers = 0;
        private bool _isWaitingForKey = false;

        public ucMicController()
        {
            ThemeManager.SetTheme(SettingsManager.Instance.Current.IsDarkMode);
            InitializeComponent();
            ThemeManager.ThemeChanged += (s, e) => ApplyTheme();
            ApplyTheme(); // Tema sistemini uyguluyoruz

            _micBackend = new MicNativeWrapper();

            chkGlobalMute.Checked = _micBackend.IsMuted();
            UpdateMicStatusIndicator(); // İlk duruma göre etiketi renklendir

            _hotkeyListener = new HotkeyListener();
            _hotkeyListener.OnHotkeyPressed += ToggleMicrophone;

            // Olayları koda güvenle bağlıyoruz
            btnSetToggleKey.Click += btnSetToggleKey_Click;
            btnSetToggleKey.KeyDown += BtnSetToggleKey_KeyDown;
            btnSetToggleKey.PreviewKeyDown += BtnSetToggleKey_PreviewKeyDown;
            chkEnableToggle.CheckedChanged += chkEnableToggle_CheckedChanged;
            chkGlobalMute.CheckedChanged += chkGlobalMute_CheckedChanged;

            // Arayüzü bellekteki mevcut ayarlarla doldur
            LoadSettingsFromManager();
        }

        private void ApplyTheme()
        {
            // Ana arka plan
            this.BackColor = ThemeManager.ContentBackground;

            // Kart Panelleri
            pnlActiveCard.BackColor = ThemeManager.SidebarBackground;
            pnlSoonCard.BackColor = ThemeManager.SidebarBackground;

            // Başlıklar
            lblTitle.ForeColor = ThemeManager.TextPrimary;
            lblActiveCardTitle.ForeColor = ThemeManager.TextPrimary;
            
            // Yakında kartının başlığı ve içeriği kasıtlı olarak pasif renklerde
            lblSoonCardTitle.ForeColor = ThemeManager.TextSecondary;
            chkEnablePTT.ForeColor = ThemeManager.TextSecondary;
            btnSetHotkey.ForeColor = ThemeManager.TextSecondary;
            btnSetHotkey.BackColor = ThemeManager.ButtonHover;

            // Yakında (Soon) Rozeti Tasarımı (Altın/Turuncu vurgu)
            lblSoonBadge.BackColor = Color.FromArgb(254, 243, 199);
            lblSoonBadge.ForeColor = Color.FromArgb(217, 119, 6);

            // Aktif Kart Etiketleri
            chkGlobalMute.ForeColor = ThemeManager.TextSecondary;
            chkEnableToggle.ForeColor = ThemeManager.TextSecondary;

            // Tuş Atama Butonu
            btnSetToggleKey.BackColor = ThemeManager.ContentBackground;
            btnSetToggleKey.ForeColor = ThemeManager.TextPrimary;
            btnSetToggleKey.FlatAppearance.BorderColor = ThemeManager.ButtonDown;
            
            ThemeManager.FormatControls(this.Controls);
        }

        // Mikrofon durumuna göre etiket metnini ve rengini güncelleyen yardımcı metod
        private void UpdateMicStatusIndicator()
        {
            if (chkGlobalMute.Checked)
            {
                lblMicStatusIndicator.Text = "Durum: Susturuldu";
                lblMicStatusIndicator.ForeColor = Color.FromArgb(239, 68, 68); // Kırmızı (Red-500)
            }
            else
            {
                lblMicStatusIndicator.Text = "Durum: Aktif";
                lblMicStatusIndicator.ForeColor = Color.FromArgb(16, 185, 129); // Yeşil (Emerald-500)
            }
        }

        // --- KISAYOL TETİKLENDİĞİNDE ÇALIŞACAK METOD ---
        private void ToggleMicrophone()
        {
            bool newMuteState = !_micBackend.IsMuted();
            _micBackend.SetMute(newMuteState);

            if (this.IsHandleCreated && !this.IsDisposed)
            {
                this.BeginInvoke(new Action(() => 
                { 
                    chkGlobalMute.Checked = newMuteState; 
                    UpdateMicStatusIndicator();
                }));
            }
        }

        // --- MERKEZİ AYAR YÖNETİMİ ---
        private void LoadSettingsFromManager()
        {
            // Dosya okuma işlemi yok, doğrudan Singleton üzerinden bellekteki veriyi çekiyoruz
            var settings = SettingsManager.Instance.Current;

            _currentKeyCode = (Keys)settings.ToggleKeyCode;
            _currentModifiers = settings.ToggleKeyModifiers;

            UpdateHotkeyButtonText();

            chkEnableToggle.Checked = settings.EnableToggleHotkey;

            if (chkEnableToggle.Checked)
            {
                RegisterGlobalHotkey();
            }
        }

        private void SaveSettingsToManager()
        {
            // Bellekteki veriyi güncelle
            var settings = SettingsManager.Instance.Current;
            settings.EnableToggleHotkey = chkEnableToggle.Checked;
            settings.ToggleKeyCode = (int)_currentKeyCode;
            settings.ToggleKeyModifiers = _currentModifiers;

            // Diske yazma emri ver
            SettingsManager.Instance.Save();
        }

        // --- KISAYOL KAYIT YÖNETİMİ ---
        private void chkEnableToggle_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkEnableToggle.Checked)
            {
                RegisterGlobalHotkey();
            }
            else
            {
                UnregisterHotKey(_hotkeyListener.Handle, HOTKEY_ID);
            }

            SaveSettingsToManager();
        }

        private void RegisterGlobalHotkey()
        {
            UnregisterHotKey(_hotkeyListener.Handle, HOTKEY_ID);

            bool success = RegisterHotKey(_hotkeyListener.Handle, HOTKEY_ID, _currentModifiers, (int)_currentKeyCode);

            if (!success && chkEnableToggle.Checked)
            {
                MessageBox.Show("Bu kısayol başka bir uygulama tarafından kullanılıyor veya sistem tarafından engellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                chkEnableToggle.Checked = false;
            }
        }

        // --- TUŞ ATAMA EKRANI ---
        private void btnSetToggleKey_Click(object? sender, EventArgs e)
        {
            _isWaitingForKey = true;
            btnSetToggleKey.Text = "Tuşa Basın... (İptal için ESC)";
            btnSetToggleKey.BackColor = ThemeManager.ButtonDown; // Dinlerken daha koyu bir renk yap

            UnregisterHotKey(_hotkeyListener.Handle, HOTKEY_ID);
            btnSetToggleKey.Focus();
        }

        private void BtnSetToggleKey_PreviewKeyDown(object? sender, PreviewKeyDownEventArgs e)
        {
            if (_isWaitingForKey) e.IsInputKey = true;
        }

        private void BtnSetToggleKey_KeyDown(object? sender, KeyEventArgs e)
        {
            if (!_isWaitingForKey) return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            if (e.KeyCode == Keys.Escape)
            {
                CancelKeyWaiting();
                return;
            }

            if (e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.Menu) return;

            _currentKeyCode = e.KeyCode;
            _currentModifiers = 0;

            if (e.Control) _currentModifiers |= 0x0002;
            if (e.Shift) _currentModifiers |= 0x0004;
            if (e.Alt) _currentModifiers |= 0x0001;

            _isWaitingForKey = false;
            btnSetToggleKey.BackColor = ThemeManager.ContentBackground; // Rengi eski haline çevir
            UpdateHotkeyButtonText();

            if (chkEnableToggle.Checked) RegisterGlobalHotkey();

            // Yeni tuş atandığında ayarları merkezi sisteme kaydet
            SaveSettingsToManager();
        }

        private void CancelKeyWaiting()
        {
            _isWaitingForKey = false;
            btnSetToggleKey.BackColor = ThemeManager.ContentBackground; // Rengi eski haline çevir
            UpdateHotkeyButtonText();
            if (chkEnableToggle.Checked) RegisterGlobalHotkey();
        }

        private void UpdateHotkeyButtonText()
        {
            string modifierText = "";
            if ((_currentModifiers & 0x0002) != 0) modifierText += "Ctrl + ";
            if ((_currentModifiers & 0x0004) != 0) modifierText += "Shift + ";
            if ((_currentModifiers & 0x0001) != 0) modifierText += "Alt + ";

            string newText = $"Kısayol: {modifierText}{_currentKeyCode}";

            // WinForms Akıllı Thread Kontrolü
            if (this.IsHandleCreated && this.InvokeRequired)
            {
                // Eğer arkaplan (background) işleminden geliyorsa güvenli şekilde arayüze ilet
                this.Invoke(new Action(() => { btnSetToggleKey.Text = newText; }));
            }
            else
            {
                btnSetToggleKey.Text = newText;
            }
        }

        private void chkGlobalMute_CheckedChanged(object? sender, EventArgs e)
        {
            UpdateMicStatusIndicator(); // Yazı ve rengi güncelle
            
            if (chkGlobalMute.Focused)
            {
                _micBackend.SetMute(chkGlobalMute.Checked);
            }
        }

        public void Cleanup()
        {
            SaveSettingsToManager(); // Kapanırken son bir kayıt al
            UnregisterHotKey(_hotkeyListener.Handle, HOTKEY_ID);
            _hotkeyListener.Dispose();
            _micBackend.SetMute(false); // Uygulama kapanırken mikrofonu kesin aç
        }
    }
}