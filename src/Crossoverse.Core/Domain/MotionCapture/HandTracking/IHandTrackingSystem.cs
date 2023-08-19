namespace Crossoverse.Core.Domain.MotionCapture.HandTracking
{
    public interface IHandTrackingSystem
    {
        void Tick();
        bool TryPeek(ref HandTrackingData data);
    }
}