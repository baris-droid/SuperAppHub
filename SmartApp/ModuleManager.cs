using System.Diagnostics;
using System.Reflection;
using SuperApp.Core;

// IAppModule'ün bulunduğu namespace
namespace SmartApp;

public sealed class ModuleManager
{
    // Yüklenen modülleri RAM'de tuttuğumuz liste
    public List<IAppModule> LoadedModules { get; } = [];

    public void LoadModules(string modulesDirectoryPath)
    {
        LoadedModules.Clear();

        // Klasör yoksa oluştur (İlk çalışma durumu)
        if (!Directory.Exists(modulesDirectoryPath))
        {
            Directory.CreateDirectory(modulesDirectoryPath);
            return; // Yüklenecek bir şey yok
        }

        // Sadece .dll dosyalarını al
        var dllFiles = Directory.GetFiles(modulesDirectoryPath, "*.dll");

        foreach (var dllPath in dllFiles)
            try
            {
                // .dll dosyasını RAM'e yükle
                var assembly = Assembly.LoadFrom(dllPath);

                // Bu dll içindeki tüm sınıflara (Type) bak
                var moduleTypes = assembly.GetTypes()
                    .Where(t => typeof(IAppModule).IsAssignableFrom(t) // IAppModule'ü implemente etmiş mi?
                                && t is { IsInterface: false, IsAbstract: false });

                // Bulunan her modül sınıfı için bir örnek oluştur
                foreach (var type in moduleTypes)
                    if (Activator.CreateInstance(type) is IAppModule moduleInstance)
                    {
                        moduleInstance.Initialize(); // Modülün kendi iç hazırlığını tetikle
                        LoadedModules.Add(moduleInstance);
                        Debug.WriteLine($"[BAŞARILI] Modül yüklendi: {moduleInstance.ModuleName}");
                    }
            }
            catch (Exception ex)
            {
                // Bir modül bozuksa veya hata verirse
                Debug.WriteLine($"[HATA] {Path.GetFileName(dllPath)} yüklenemedi: {ex.Message}");
            }
    }

    public void UnloadAll()
    {
        // Uygulama kapanırken tüm modüllerin kaynaklarını temizlediğinden emin ol
        foreach (var module in LoadedModules) module.Cleanup();
        LoadedModules.Clear();
    }
}