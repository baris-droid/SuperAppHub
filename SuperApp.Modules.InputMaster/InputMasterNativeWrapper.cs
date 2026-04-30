using System.Runtime.InteropServices;

namespace SmartApp
{
    public class InputMasterNativeWrapper : IInputMasterBackend
    {
        private const string DllName = "InputMasterCore.dll";

        // --- DLL IMPORT TANIMLAMALARI ---
        [DllImport(DllName, EntryPoint = "SetInputSettings", CallingConvention = CallingConvention.Cdecl)]
        private static extern void Native_SetInputSettings(int scrollMult, int volSens);

        [DllImport(DllName, EntryPoint = "SetInputHotkeys", CallingConvention = CallingConvention.Cdecl)]
        private static extern void Native_SetInputHotkeys(int scrollKey, int volKey);

        [DllImport(DllName, EntryPoint = "ProcessInputTick", CallingConvention = CallingConvention.Cdecl)]
        private static extern void Native_ProcessInputTick();


        // --- INTERFACE (ARAYÜZ) UYGULAMALARI ---
        // Arayüzümüz (UI) bu temiz isimli metotları çağırır, biz de arka planda karmaşaya yer vermeden Native_ metotlara yönlendiririz.

        public void SetInputSettings(int scrollMult, int volSens)
        {
            Native_SetInputSettings(scrollMult, volSens);
        }

        public void SetInputHotkeys(int scrollKey, int volKey)
        {
            Native_SetInputHotkeys(scrollKey, volKey);
        }

        public void ProcessInputTick()
        {
            Native_ProcessInputTick();
        }
    }
}