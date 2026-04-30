namespace SuperApp.Core
{
    // Verilerimizi RAM'de ve JSON dosyasında tutacak şablonumuz
    public class AppSettings
    {
        public string ClientId { get; set; } = "";
        public string Details { get; set; } = "";
        public string State { get; set; } = "";
        public string ImageLink { get; set; } = "";

        public bool MinimizeToTray { get; set; } = false;

        
        public bool EnableToggleHotkey { get; set; } = false;
        public int ToggleKeyCode { get; set; } = 77; // Varsayılan: M tuşu
        public int ToggleKeyModifiers { get; set; } = 0; // Varsayılan: Modifikatör yok (Ctrl, Alt vb.)


        // --- YENİ: Ağ ve Güç İzleme Ayarları ---
        public double NetworkThresholdKbps { get; set; } = 100.0;
        public int NetworkWaitTimeSeconds { get; set; } = 180;
        public int NetworkActionType { get; set; } = 0; // 0 = Uyku Modu (Sleep), 1 = Kapatma (Shutdown)

        // --- YENİ: Gelişmiş Girdi (Input Master) Ayarları ---
        public int InputScrollMultiplier { get; set; } = 15;
        public int InputVolumeSensitivity { get; set; } = 20;
        public int InputScrollKey { get; set; } = 18; // Varsayılan Keys.Menu (Alt)
        public int InputVolumeKey { get; set; } = 17; // Varsayılan Keys.ControlKey (Ctrl)

        // --- YENİ: Göz Sağlığı (20-20-20) Ayarları ---
        public int EyeCareWorkMinutes { get; set; } = 20;
        public int EyeCareRestSeconds { get; set; } = 20;
        public int EyeCareNotificationLocation { get; set; } = 0; // 0: Ekran Ortası, 1: Sağ Alt Köşe
        public int EyeCareOpacity { get; set; } = 85; // Opaklık yüzdesi (10 ile 100 arası). Varsayılan: %85
    }
}