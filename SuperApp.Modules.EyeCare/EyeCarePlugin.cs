using SmartApp;
using SuperApp.Core;
using System.Windows.Forms;

namespace SmartApp;

public class EyeCarePlugin : IAppModule
{
    private ucEyeCare? _mainInterface;

    public string ModuleName => "Göz Sağlığı";
    public string Description => "20-20-20 kuralına göre oyun oynarken göz dinlendirme hatırlatıcısı.";

    public UserControl GetMainInterface()
    {
        // Bellek dostu Lazy Loading (Sadece butona tıklanırsa RAM'de yer kaplar)
        _mainInterface ??= new ucEyeCare();
        return _mainInterface;
    }

    public void Initialize()
    {
        // Modül yüklenirken yapılacak başlangıç işlemleri
    }

    public void Cleanup()
    {
        // Kapanırken arka planda çalışan zamanlayıcıları ve bildirim formunu güvenle yokediyoruz
        _mainInterface?.Cleanup();
    }
}