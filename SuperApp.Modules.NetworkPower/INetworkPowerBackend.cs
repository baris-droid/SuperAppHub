namespace SmartApp
{
    public interface INetworkPowerBackend
    {
        ulong GetTotalBytesReceived();
        void SuspendSystem();
        void ShutdownSystem();
    }
}