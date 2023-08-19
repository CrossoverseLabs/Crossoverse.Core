using System;

namespace Crossoverse.Core.Domain.MotionCapture.HandTracking
{
    public sealed class HandTrackingData
    {
        public readonly Joint[] Joints;

        public HandTrackingData(int jointCount)
        {
            Joints = new Joint[jointCount];
            for (int i = 0; i < jointCount; i++)
            {
                Joints[i] = new Joint(-1);
            }
        }

        public void CopyTo(ref HandTrackingData destination)
        {
            Array.Copy(Joints, destination.Joints, Joints.Length);
        }
    }
}