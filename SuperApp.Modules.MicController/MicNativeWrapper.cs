using System.Runtime.InteropServices;

namespace SmartApp
{
    public interface IMicBackend
    {
        bool SetMute(bool mute);
        bool IsMuted();
    }

    public class MicNativeWrapper : IMicBackend
    {
        private const string DllName = "MicBackend.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool SetMicrophoneMute(bool mute);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern bool GetMicrophoneMute(out bool isMuted);

        public bool SetMute(bool mute)
        {
            return SetMicrophoneMute(mute);
        }

        public bool IsMuted()
        {
            if (GetMicrophoneMute(out bool isMuted))
            {
                return isMuted;
            }
            return false; // Hata durumunda varsayılan
        }
    }
}