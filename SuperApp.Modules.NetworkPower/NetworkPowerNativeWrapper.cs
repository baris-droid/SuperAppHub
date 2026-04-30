using System.Runtime.InteropServices;

namespace SmartApp
{
    public class NetworkPowerNativeWrapper : INetworkPowerBackend
    {
        [DllImport("NetPowerCore.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern ulong GetTotalBytesReceived();

        [DllImport("NetPowerCore.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void SuspendSystem();

        [DllImport("NetPowerCore.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern void ShutdownSystem();

        ulong INetworkPowerBackend.GetTotalBytesReceived() => GetTotalBytesReceived();
        void INetworkPowerBackend.SuspendSystem() => SuspendSystem();
        void INetworkPowerBackend.ShutdownSystem() => ShutdownSystem();
    }
}