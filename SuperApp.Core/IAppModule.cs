using System.Windows.Forms;

namespace SuperApp.Core;

public interface IAppModule
{
    string ModuleName { get; }
    string Description { get; }

    UserControl GetMainInterface();

    void Initialize();
    void Cleanup();
}