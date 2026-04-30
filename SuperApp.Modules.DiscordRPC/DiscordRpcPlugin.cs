using SmartApp;
using SuperApp.Core;
using System.Windows.Forms;

namespace SmartApp;

// Sınıfın public olması çok önemlidir, aksi takdirde ana makine (Reflection) bunu bulamaz.
public class DiscordRpcPlugin : IAppModule
{
    // Arayüzümüzü RAM'de bir kez oluşturup saklıyoruz (Caching)
    private ucDiscordRPC _mainInterface;

    public string ModuleName => "Oyun Durumu";
    public string Description => "Discord Rich Presence (Zengin Durum) yönetim modülü.";

    public UserControl GetMainInterface()
    {
        // Eğer arayüz henüz oluşturulmadıysa oluştur
        if (_mainInterface == null)
        {
            _mainInterface = new ucDiscordRPC();
        }
        return _mainInterface;
    }

    public void Initialize()
    {
        // Modül ilk yüklendiğinde yapılacak ön hazırlıklar (Gerekirse)
        // Örneğin C kütüphanesi (dll) kontrolleri burada yapılabilir.
        // İleride eklenebilir.
    }

    public void Cleanup()
    {
        // Ana program kapanırken arayüzün içindeki temizlik metodunu çağırıyoruz
        _mainInterface?.Cleanup();
    }
}