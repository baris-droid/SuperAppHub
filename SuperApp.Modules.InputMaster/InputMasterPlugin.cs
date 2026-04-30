using SmartApp;
using SuperApp.Core;
using System.Windows.Forms;

namespace SmartApp;

public class InputMasterPlugin : IAppModule
{
    private ucInputMaster? _mainInterface;

    public string ModuleName => "Girdi ve Kısayollar";
    public string Description => "Klavye ve fare ile özel kaydırma (scroll) ve ses simülasyonları yapan modül.";

    public UserControl GetMainInterface()
    {
        // Bellek dostu
        _mainInterface ??= new ucInputMaster();
        return _mainInterface;
    }

    public void Initialize()
    {
        // Modül yüklenirken yapılacak başlangıç işlemleri (şimdilik boş)
    }

    public void Cleanup()
    {
        // Kapanırken 10ms'lik döngüyü (Task) güvenle sonlandırdık
        _mainInterface?.Cleanup();
    }
}