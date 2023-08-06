using System.Numerics;

namespace Crossoverse.Core.Domain.MotionCapture.HandTracking
{
    public struct Joint
    {
        public int Id;
        public Vector3 Position;
        public Quaternion Orientation;
        public float ConfidenceLevel;

        public Joint(int id)
        {
            Id = id;
            Position = Vector3.Zero;
            Orientation = Quaternion.Identity;
            ConfidenceLevel = 0.0f;
        }
    }
}