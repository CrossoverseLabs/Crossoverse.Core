using System.Numerics;
using UnityEngine;

namespace Crossoverse.Core.Unity
{
    public static partial class SystemNumericsExtensions
    {
        public static UnityEngine.Vector3 ToUnity(this System.Numerics.Vector3 vector)
        {
            return new UnityEngine.Vector3(vector.X, vector.Y, vector.Z);
        }

        public static UnityEngine.Quaternion ToUnity(this System.Numerics.Quaternion quaternion)
        {
            return new UnityEngine.Quaternion(quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        public static void ConvertToUnity(this System.Numerics.Vector3 source, ref UnityEngine.Vector3 target)
        {
            target.x = source.X;
            target.y = source.Y;
            target.z = source.Z;
        }

        public static void ConvertToUnity(this System.Numerics.Quaternion source, ref UnityEngine.Quaternion target)
        {
            target.x = source.X;
            target.y = source.Y;
            target.z = source.Z;
            target.w = source.W;
        }
    }
}
