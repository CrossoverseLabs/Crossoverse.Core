namespace Crossoverse.Core.Domain.MotionCapture.EyeTracking
{
    public interface IEyeTrackingSystem
    {
        void Tick();
        bool TryPeek(ref EyeTrackingData result);
    }
}