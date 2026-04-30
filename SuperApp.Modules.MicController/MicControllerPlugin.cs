using System.Windows.Forms;
using SuperApp.Core;

namespace SmartApp;

public class MicControllerPlugin : IAppModule
{
    // Arayüz nesnesini bellekte tutuyoruz
    private ucMicController? _mainInterface;

    public string ModuleName => "Ses Denetimi";
    public string Description => "Sistem mikrofonunu global kısayollarla yönetme modülü.";

    public UserControl GetMainInterface()
    {
        _mainInterface ??= new ucMicController();
        return _mainInterface;
    }

    public void Initialize()
    {
        // Gerekirse modül yüklenirken yapılacak başlangıç işlemleri
    }

    public void Cleanup()
    {
        _mainInterface?.Cleanup();
    }
}