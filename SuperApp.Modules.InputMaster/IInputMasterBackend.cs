namespace SmartApp
{
    public interface IInputMasterBackend
    {
        // Kaydırma hızı ve ses hassasiyetini ayarlar
        void SetInputSettings(int scrollMult, int volSens);

        // Kullanıcının atadığı kısayol tuşlarını (Alt, Ctrl vb.) ayarlar
        void SetInputHotkeys(int scrollKey, int volKey);

        // Asenkron döngümüzün her 10ms'de bir çağıracağı tetikleyici metot
        void ProcessInputTick();
    }
}