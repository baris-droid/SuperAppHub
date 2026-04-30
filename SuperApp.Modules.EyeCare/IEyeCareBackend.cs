namespace SmartApp
{
    public interface IEyeCareBackend
    {
        void StartEyeCare(int workMinutes, int restSeconds);
        void StopEyeCare();
        int GetEyeCareState();
        int GetRemainingSeconds();
    }
}