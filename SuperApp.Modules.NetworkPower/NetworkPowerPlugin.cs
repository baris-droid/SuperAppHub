using SmartApp;
using SuperApp.Core;
using System.Windows.Forms;

namespace SmartApp;

public class NetworkPowerPlugin : IAppModule
{
    private ucNetworkPower? _mainInterface;

    public string ModuleName => "Ağ Otomasyonu";
    public string Description => "Ağ trafiğini izleyerek indirme bitince bilgisayarı kapatan/uyutan otomasyon modülü.";

    public UserControl GetMainInterface()
    {
        // Temiz ve performanslı
        _mainInterface ??= new ucNetworkPower();
        return _mainInterface;
    }

    public void Initialize()
    {
        // Modül ayağa kalkarken yapılacak özel bir işlem varsa buraya yazılacak
    }

    public void Cleanup()
    {
        // Uygulama kapanırken arkada çalışan Task'leri ve Token'ları temizliyor
        _mainInterface?.Cleanup();
    }
}