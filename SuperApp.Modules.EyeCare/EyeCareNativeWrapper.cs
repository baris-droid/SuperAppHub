using System.Runtime.InteropServices;

namespace SmartApp
{
    public class EyeCareNativeWrapper : IEyeCareBackend
    {
        private const string DllName = "EyeCareCore.dll";

        [DllImport(DllName, EntryPoint = "StartEyeCare", CallingConvention = CallingConvention.Cdecl)]
        private static extern void Native_StartEyeCare(int workMinutes, int restSeconds);

        [DllImport(DllName, EntryPoint = "StopEyeCare", CallingConvention = CallingConvention.Cdecl)]
        private static extern void Native_StopEyeCare();

        [DllImport(DllName, EntryPoint = "GetEyeCareState", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Native_GetEyeCareState();

        [DllImport(DllName, EntryPoint = "GetRemainingSeconds", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Native_GetRemainingSeconds();

        public void StartEyeCare(int workMinutes, int restSeconds) => Native_StartEyeCare(workMinutes, restSeconds);
        public void StopEyeCare() => Native_StopEyeCare();
        public int GetEyeCareState() => Native_GetEyeCareState();
        public int GetRemainingSeconds() => Native_GetRemainingSeconds();
    }
}