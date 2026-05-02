using SuperApp.Core;
using SuperApp.Core.UI;

namespace SmartApp;

public partial class Form1 : Form
{
    private readonly ModuleManager _moduleManager;
    private int _currentButtonY = 115;
    private MainMenuControl _mainMenuControlPage = null!;

    // --- SİSTEM TEPSİSİ VE KAPANMA YÖNETİMİ ---
    private NotifyIcon _trayIcon = null!;
    private ContextMenuStrip _trayMenu = null!;

    public Form1()
    {
        ThemeManager.SetTheme(SettingsManager.Instance.Current.IsDarkMode);
        InitializeComponent();
        SetupFocusLossOnBackgroundClick(this);
        ThemeManager.ThemeChanged += (s, e) => ApplyTheme();
        ApplyTheme();

        _moduleManager = new ModuleManager();

        SetupTrayIcon();
        AnaMenuyuHazirla();
        ModulleriYukleVeArayuzuOlustur();
    }

    private void ApplyTheme()
    {
        // Ana arka plan ve paneller
        BackColor = ThemeManager.ContentBackground;
        pnlSidebar.BackColor = ThemeManager.SidebarBackground;
        pnlContent.BackColor = ThemeManager.ContentBackground;

        lblTitle.ForeColor = ThemeManager.TextPrimary;
        lblVersion.ForeColor = ThemeManager.TextSecondary;
        pnlNavIndicator.BackColor = ThemeManager.AccentColor;

        // YENİ: Sol menüdeki TÜM butonları (Kontrol Paneli + Dinamik Modüller) bul ve güncelle
        foreach (Control ctrl in pnlSidebar.Controls)
            if (ctrl is Button btn)
            {
                // Üzerine gelme (Hover) ve tıklama (Down) renklerini karanlık temaya uygun hale getir
                btn.FlatAppearance.MouseOverBackColor = ThemeManager.ButtonHover;
                btn.FlatAppearance.MouseDownBackColor = ThemeManager.ButtonDown;

                // Butonun o an seçili olan sekme olup olmadığını, yanındaki mavi çubuğun hizasından anlıyoruz
                var isActive = pnlNavIndicator.Top == btn.Top + 5;

                // Eğer aktif sekme ise rengini Vurgu Rengi (Mavi) yap, değilse Pasif Yazı Rengi (Gri) yap
                btn.ForeColor = isActive ? ThemeManager.AccentColor : ThemeManager.TextSecondary;
            }
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
        this.ActiveControl = null;
    }
    
    private void AnaMenuyuHazirla()
    {
        _mainMenuControlPage = new MainMenuControl { Dock = DockStyle.Fill };
        pnlContent.Controls.Add(_mainMenuControlPage);

        NavigasyonYap(_mainMenuControlPage, btnOpenMainMenu);
    }

    private void ModulleriYukleVeArayuzuOlustur()
    {
        var modulesPath = Path.Combine(Application.StartupPath, "Modules");

        if (!Directory.Exists(modulesPath))
        {
            Directory.CreateDirectory(modulesPath);
            return;
        }

        _moduleManager.LoadModules(modulesPath);

        foreach (var module in _moduleManager.LoadedModules) DinamikButonOlustur(module);
    }

    private void DinamikButonOlustur(IAppModule module)
    {
        var btnModule = new Button
        {
            Text = module.ModuleName,
            Size = new Size(238, 40),
            Location = new Point(10, _currentButtonY),
            Cursor = Cursors.Hand,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162),
            ForeColor = ThemeManager.TextSecondary,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(15, 0, 0, 0)
        };

        btnModule.FlatAppearance.BorderSize = 0;
        btnModule.FlatAppearance.MouseOverBackColor = ThemeManager.ButtonHover;
        btnModule.FlatAppearance.MouseDownBackColor = ThemeManager.ButtonDown;

        var moduleUI = module.GetMainInterface();
        moduleUI.Dock = DockStyle.Fill;
        moduleUI.Visible = false;

        pnlContent.Controls.Add(moduleUI);

        btnModule.Click += (sender, e) => NavigasyonYap(moduleUI, btnModule);

        pnlSidebar.Controls.Add(btnModule);

        _currentButtonY += 45;
    }

    private void NavigasyonYap(UserControl aktifSayfa, Button aktifButon)
    {
        // Yalnızca ekranda görünen modülü gizleyerek gereksiz CPU kullanımını (overhead) önlüyoruz
        foreach (Control ctrl in pnlContent.Controls)
            if (ctrl is UserControl uc && uc.Visible)
                uc.Hide();

        aktifSayfa.Show();
        aktifSayfa.BringToFront();

        pnlNavIndicator.Height = aktifButon.Height - 10;
        pnlNavIndicator.Top = aktifButon.Top + 5;
        pnlNavIndicator.Left = 0;
        pnlNavIndicator.BringToFront();

        ResetButtonColors();
        aktifButon.ForeColor = ThemeManager.AccentColor;
        aktifButon.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
    }

    private void ResetButtonColors()
    {
        foreach (Control ctrl in pnlSidebar.Controls)
            if (ctrl is Button btn)
            {
                btn.ForeColor = ThemeManager.TextSecondary;
                btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            }
    }

    private void btnOpenMainMenu_Click(object? sender, EventArgs e)
    {
        if (sender is Button btn) NavigasyonYap(_mainMenuControlPage, btn);
    }

    private void SetupTrayIcon()
    {
        _trayMenu = new ContextMenuStrip();
        _trayMenu.Items.Add("Paneli Göster", null, (s, e) => RestoreForm());
        _trayMenu.Items.Add("Tamamen Çıkış Yap", null, (s, e) => ForceExit());

        _trayIcon = new NotifyIcon
        {
            Icon = SystemIcons.Application,
            ContextMenuStrip = _trayMenu,
            Text = "Super App Hub",
            Visible = false
        };

        _trayIcon.DoubleClick += (s, e) => RestoreForm();
    }

    private void RestoreForm()
    {
        Show();
        WindowState = FormWindowState.Normal;
        _trayIcon.Visible = false;
    }

    private void ForceExit()
    {
        _moduleManager.UnloadAll();
        _trayIcon.Dispose();
        Environment.Exit(0);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (e.CloseReason == CloseReason.UserClosing && SettingsManager.Instance.Current.MinimizeToTray)
        {
            e.Cancel = true;
            Hide();
            _trayIcon.Visible = true;
        }
        else
        {
            _moduleManager.UnloadAll();
            Thread.Sleep(100);

            _trayIcon.Dispose();
            base.OnFormClosing(e);
        }
    }
}