using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace SuperApp.Core
{
    public sealed class SettingsManager
    {
        private const string SettingsFile = "ayarlar.json";
        
        private static readonly Lazy<SettingsManager> _instance = new(() => new SettingsManager());

        // Dışarıdan erişim noktamız
        public static SettingsManager Instance => _instance.Value;
        
        public AppSettings Current { get; }
        
        private SettingsManager()
        {
            Current = Load();
        }

        // Dosyayı sadece uygulama ilk açıldığında veya sınıf ilk çağrıldığında 1 kez okur
        private AppSettings Load()
        {
            if (!File.Exists(SettingsFile))
            {
                return new AppSettings(); // Dosya yoksa temiz bir başlangıç yap
            }

            try
            {
                string json = File.ReadAllText(SettingsFile);
                return JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ayarlar yüklenirken kritik hata: {ex.Message}");
                return new AppSettings(); // Çökme yerine varsayılan ayarlarla devam et
            }
        }

        // Diske yazma işlemi. İhtiyaç duyulan anlarda (örneğin buton tıklamalarında veya uygulama kapanırken) çağrılır.
        public void Save()
        {
            try
            {
                string json = JsonSerializer.Serialize(Current, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(SettingsFile, json);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Ayarlar diske yazılamadı: {ex.Message}");
            }
        }
    }
}