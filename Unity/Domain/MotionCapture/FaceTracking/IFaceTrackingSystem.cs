namespace Crossoverse.Core.Domain.MotionCapture.FaceTracking
{
    public interface IFaceTrackingSystem
    {
        void Tick();
        bool TryDequeue(ref FaceTrackingData data);
    }
}