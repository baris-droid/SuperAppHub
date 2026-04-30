namespace SmartApp;

public partial class MainMenuControl : UserControl
{
    public MainMenuControl()
    {
        InitializeComponent();
        LoadSettings();
    }

    private void LoadSettings()
    {
        // SettingsManager üzerinden ayarları RAM'den güvenli bir şekilde çekiyoruz.
        chkMinimizeToTray.Checked = SettingsManager.Instance.Current.MinimizeToTray;
    }

    private void chkMinimizeToTray_CheckedChanged(object sender, EventArgs e)
    {
        // Değeri sadece RAM'deki modele işliyoruz
        SettingsManager.Instance.Current.MinimizeToTray = chkMinimizeToTray.Checked;

        // Diske yazma işini yine merkezi yöneticiye devrediyoruz
        SettingsManager.Instance.Save();
    }
}