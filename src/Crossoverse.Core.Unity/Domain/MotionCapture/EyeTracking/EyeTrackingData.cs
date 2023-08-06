using System;
using UnityEngine;

namespace Crossoverse.Core.Domain.MotionCapture.EyeTracking
{
    [Serializable]
    public sealed class EyeTrackingData
    {
        public Quaternion HeadRotation = Quaternion.identity;
        public Quaternion LeftEyeLocalRotation = Quaternion.identity;
        public Quaternion RightEyeLocalRotation = Quaternion.identity;

        public void CopyTo(ref EyeTrackingData destination)
        {
            destination.HeadRotation = HeadRotation;
            destination.LeftEyeLocalRotation = LeftEyeLocalRotation;
            destination.RightEyeLocalRotation = RightEyeLocalRotation;
        }
    }
}