using SuperApp.Core;
using SuperApp.Core.UI;

namespace SmartApp;

public partial class MainMenuControl : UserControl
{
    public MainMenuControl()
    {
        InitializeComponent();

        // Uygulama genelinde tema değiştiğinde bu sayfanın da anında güncellenmesini sağla
        ThemeManager.ThemeChanged += (sender, e) => ApplyTheme();

        ApplyTheme(); // Tema sistemimizi bu sayfaya da uyguluyoruz
        LoadSettings();
    }

    private void ApplyTheme()
    {
        // Ana arka planı ThemeManager'dan alıyoruz (Açık gri)
        BackColor = ThemeManager.ContentBackground;

        // Kart görünümlerinin arka planı (Beyaz yaparak gri arkaplandan öne çıkarıyoruz)
        pnlSettingsCard.BackColor = ThemeManager.SidebarBackground;
        pnlInfoCard.BackColor = ThemeManager.SidebarBackground;

        // Başlık metinleri (Koyu/Belirgin renk)
        lblWelcome.ForeColor = ThemeManager.TextPrimary;
        lblSettingsTitle.ForeColor = ThemeManager.TextPrimary;
        lblInfoTitle.ForeColor = ThemeManager.TextPrimary;

        // Açıklama ve Alt Metinler (Pasif/Okunabilir gri renk)
        chkMinimizeToTray.ForeColor = ThemeManager.TextSecondary;
        chkDarkMode.ForeColor = ThemeManager.TextSecondary;
        lblInfoDesc.ForeColor = ThemeManager.TextSecondary;

        // Formdaki tüm CheckBox'ları bul ve onlara modern beyaz tik tasarımını uygula
        ThemeManager.FormatControls(Controls);
    }

    private void LoadSettings()
    {
        // SettingsManager üzerinden ayarları RAM'den güvenli bir şekilde çekiyoruz.
        var settings = SettingsManager.Instance.Current;
        chkMinimizeToTray.Checked = SettingsManager.Instance.Current.MinimizeToTray;
        chkDarkMode.Checked = settings.IsDarkMode;
    }

    private void chkMinimizeToTray_CheckedChanged(object sender, EventArgs e)
    {
        // Değeri sadece RAM'deki modele işliyoruz
        SettingsManager.Instance.Current.MinimizeToTray = chkMinimizeToTray.Checked;

        // Diske yazma işini yine merkezi yöneticiye devrediyoruz
        SettingsManager.Instance.Save();
    }

    // --- YENİ TEMA DEĞİŞTİRME OLAYI ---
    private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
    {
        // 1. Ayarı RAM'e kaydet
        SettingsManager.Instance.Current.IsDarkMode = chkDarkMode.Checked;

        // 2. Ayarı diske (JSON) kaydet
        SettingsManager.Instance.Save();

        // 3. Yeni temayı tüm uygulamaya anında uygula (Bu satır ThemeChanged olayını tetikleyecek)
        ThemeManager.SetTheme(chkDarkMode.Checked);
    }
}