//using SmartApp.SystemCore;
using SuperApp.Core;
// IAppModule'ün bulunduğu yer

// ModuleManager'ın bulunduğu yer

namespace SmartApp;

public class Form1 : Form
{
    // Modül Yöneticimizi tanımlıyoruz 
    private readonly ModuleManager _moduleManager;

    // Dinamik butonların ekrandaki Y (dikey) koordinatını takip etmek için
    // İlk butonumuz Kontrol Paneli (Y=62) olduğu için, dinamik butonlar 106'dan başlayacak.
    private int _currentButtonY = 106;

    // Ana menü (Kontrol Paneli) her zaman sabit kalacak, bu uygulamanın kalbi
    private MainMenuControl _mainMenuControlPage = null!;

    // --- SİSTEM TEPSİSİ VE KAPANMA YÖNETİMİ ---
    private NotifyIcon _trayIcon = null!;
    private ContextMenuStrip _trayMenu = null!;
    private Button btnOpenMainMenu;
    private Label label1;

    private Label label2;
    private Panel pnlContent;
    private Panel pnlNavIndicator;


    // --- ARAYÜZ OLUŞTURUCU (Designer Kodları) ---
    private Panel pnlSidebar;

    public Form1()
    {
        InitializeComponent();

        // 1. Modül Yöneticisini ayağa kaldır
        _moduleManager = new ModuleManager();

        // 2. Ana bileşenleri hazırla
        SetupTrayIcon();
        AnaMenuyuHazirla();

        // 3. Klasördeki modülleri bul ve butonlarını oluştur
        ModulleriYukleVeArayuzuOlustur();
    }

    private void AnaMenuyuHazirla()
    {
        _mainMenuControlPage = new MainMenuControl { Dock = DockStyle.Fill };
        pnlContent.Controls.Add(_mainMenuControlPage);

        // Form ilk açıldığında doğrudan Ana Menüyü göster
        NavigasyonYap(_mainMenuControlPage, btnOpenMainMenu);
    }

    private void ModulleriYukleVeArayuzuOlustur()
    {
        // Modüllerin bulunacağı klasör yolu (Uygulamanın çalıştığı yerdeki 'Modules' klasörü)
        var modulesPath = Path.Combine(Application.StartupPath, "Modules");

        // DLL'leri tarar ve RAM'e yükler
        _moduleManager.LoadModules(modulesPath);

        // Yüklenen her bir modül için sol menüye dinamik buton ekle
        foreach (var module in _moduleManager.LoadedModules) DinamikButonOlustur(module);
    }

    private void DinamikButonOlustur(IAppModule module)
    {
        // 1. Butonun fiziksel özelliklerini mevcut tasarımına uygun olarak yarat
        var btnModule = new Button
        {
            Text = module.ModuleName, // Modülün IAppModule sözleşmesindeki adı
            Size = new Size(121, 38),
            Location = new Point(12, _currentButtonY),
            Cursor = Cursors.Hand,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162),
            ForeColor = Color.FromArgb(107, 114, 128) // Varsayılan pasif gri renk
        };

        // Kenarlıkları ve tıklama efektlerini ayarla
        btnModule.FlatAppearance.BorderSize = 0;
        btnModule.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
        btnModule.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 231, 235);

        // 2. Modülün Arayüzünü (UserControl) RAM'de hazırla ama henüz gösterme
        var moduleUI = module.GetMainInterface();
        moduleUI.Dock = DockStyle.Fill;
        moduleUI.Visible = false; // Tıklanana kadar gizli kalacak
        pnlContent.Controls.Add(moduleUI);

        // 3. Olay Yönlendirmesi
        // Butona tıklandığında hangi arayüzün açılacağını kodla birbirine bağlıyoruz
        btnModule.Click += (sender, e) => NavigasyonYap(moduleUI, btnModule);

        // 4. Butonu sol panele ekle
        pnlSidebar.Controls.Add(btnModule);

        // Bir sonraki buton için Y eksenini aşağı kaydır (38 buton boyu + 6 boşluk = 44)
        _currentButtonY += 44;
    }

    // DRY (Don't Repeat Yourself) Prensibi: Tek bir navigasyon metodu her şeyi çözer
    private void NavigasyonYap(UserControl aktifSayfa, Button aktifButon)
    {
        // 1. Modül Değişimi: Tüm panelleri gizle, sadece isteneni öne çıkar
        foreach (Control ctrl in pnlContent.Controls)
            if (ctrl is UserControl uc)
                uc.Hide();

        aktifSayfa.Show();
        aktifSayfa.BringToFront();

        // 2. UI Güncellemesi: Mavi aktiflik çizgisini tıklanan butona hizala
        pnlNavIndicator.Height = aktifButon.Height;
        pnlNavIndicator.Top = aktifButon.Top;
        pnlNavIndicator.Left = aktifButon.Left;
        pnlNavIndicator.BringToFront();

        // 3. Renk Güncellemesi
        ResetButtonColors();
        aktifButon.ForeColor = Color.FromArgb(37, 99, 235); // Aktif mavi
    }

    private void ResetButtonColors()
    {
        var passiveColor = Color.FromArgb(107, 114, 128);

        // pnlSidebar içindeki tüm butonları bul ve renklerini sıfırla
        foreach (Control ctrl in pnlSidebar.Controls)
            if (ctrl is Button btn)
                btn.ForeColor = passiveColor;
    }

    // Form1'in (Designer) içindeki tek fiziksel buton tıklaması (Ana Menü)
    private void btnOpenMainMenu_Click(object? sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            NavigasyonYap(_mainMenuControlPage, btn);
        }
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
        // Çıkış yaparken Modül Yöneticisine tüm modülleri güvenle kapatma
        _moduleManager.UnloadAll();
        _trayIcon.Dispose();
        Environment.Exit(0);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        // SettingsManager üzerinden bellekteki ayarı okuyoruz
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

    /// <summary>
    ///     Required method for Designer support - do not modify
    ///     the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pnlSidebar = new Panel();
        label2 = new Label();
        pnlNavIndicator = new Panel();
        label1 = new Label();
        btnOpenMainMenu = new Button();
        pnlContent = new Panel();
        pnlSidebar.SuspendLayout();
        SuspendLayout();
        // 
        // pnlSidebar
        // 
        pnlSidebar.BackColor = Color.White;
        pnlSidebar.Controls.Add(label2);
        pnlSidebar.Controls.Add(pnlNavIndicator);
        pnlSidebar.Controls.Add(label1);
        pnlSidebar.Controls.Add(btnOpenMainMenu);
        pnlSidebar.Dock = DockStyle.Left;
        pnlSidebar.Location = new Point(0, 0);
        pnlSidebar.Name = "pnlSidebar";
        pnlSidebar.Size = new Size(193, 453);
        pnlSidebar.TabIndex = 0;
        // 
        // label2
        // 
        label2.Location = new Point(12, 421);
        label2.Name = "label2";
        label2.Size = new Size(100, 23);
        label2.TabIndex = 7;
        label2.Text = "v1.6.1";
        // 
        // pnlNavIndicator
        // 
        pnlNavIndicator.BackColor = Color.FromArgb(37, 99, 235);
        pnlNavIndicator.Location = new Point(0, 62);
        pnlNavIndicator.Name = "pnlNavIndicator";
        pnlNavIndicator.Size = new Size(4, 38);
        pnlNavIndicator.TabIndex = 6;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
        label1.ForeColor = Color.FromArgb(31, 41, 55);
        label1.Location = new Point(12, 13);
        label1.Name = "label1";
        label1.Size = new Size(161, 40);
        label1.TabIndex = 5;
        label1.Text = "Super App";
        // 
        // btnOpenMainMenu
        // 
        btnOpenMainMenu.Cursor = Cursors.Hand;
        btnOpenMainMenu.FlatAppearance.BorderSize = 0;
        btnOpenMainMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(229, 231, 235);
        btnOpenMainMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
        btnOpenMainMenu.FlatStyle = FlatStyle.Flat;
        btnOpenMainMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
        btnOpenMainMenu.ForeColor = Color.FromArgb(107, 114, 128);
        btnOpenMainMenu.Location = new Point(12, 62);
        btnOpenMainMenu.Name = "btnOpenMainMenu";
        btnOpenMainMenu.Size = new Size(121, 38);
        btnOpenMainMenu.TabIndex = 2;
        btnOpenMainMenu.Text = "Kontrol Paneli";
        btnOpenMainMenu.UseVisualStyleBackColor = true;
        btnOpenMainMenu.Click += btnOpenMainMenu_Click;
        // 
        // pnlContent
        // 
        pnlContent.BackColor = Color.FromArgb(243, 244, 246);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(193, 0);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new Size(744, 453);
        pnlContent.TabIndex = 1;
        // 
        // Form1
        // 
        BackColor = Color.FromArgb(243, 244, 246);
        ClientSize = new Size(937, 453);
        Controls.Add(pnlContent);
        Controls.Add(pnlSidebar);
        Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
        ShowIcon = false;
        pnlSidebar.ResumeLayout(false);
        pnlSidebar.PerformLayout();
        ResumeLayout(false);
    }
}