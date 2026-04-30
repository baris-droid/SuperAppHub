using System.Windows.Forms;
using SuperApp.Core;

namespace SmartApp;

public class SecretsPlugin : IAppModule
{
    private ucEasterEggs? _mainInterface;
    
    // Eğlencesine ekledim gereksiz

    public string ModuleName => "Terminal Sırları";
    public string Description => "Sistemdeki gizli özellikleri ve retro protokolleri barındırır.";

    public UserControl GetMainInterface()
    {
        _mainInterface ??= new ucEasterEggs();
        return _mainInterface;
    }

    public void Initialize() { }

    public void Cleanup() { }
}