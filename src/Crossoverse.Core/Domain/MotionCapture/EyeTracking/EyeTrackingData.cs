using System;
using System.Numerics;

namespace Crossoverse.Core.Domain.MotionCapture.EyeTracking
{
    [Serializable]
    public sealed class EyeTrackingData
    {
        public Quaternion HeadRotation = new(0.0f, 0.0f, 0.0f, 1.0f); // Identity
        public Quaternion LeftEyeLocalRotation = new(0.0f, 0.0f, 0.0f, 1.0f); // Identity
        public Quaternion RightEyeLocalRotation = new(0.0f, 0.0f, 0.0f, 1.0f); // Identity

        public void CopyTo(ref EyeTrackingData destination)
        {
            destination.HeadRotation = HeadRotation;
            destination.LeftEyeLocalRotation = LeftEyeLocalRotation;
            destination.RightEyeLocalRotation = RightEyeLocalRotation;
        }
    }
}