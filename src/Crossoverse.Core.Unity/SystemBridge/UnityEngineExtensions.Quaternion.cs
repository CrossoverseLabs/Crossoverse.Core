using System.Numerics;
using UnityEngine;

namespace Crossoverse.Core.Unity
{
    public static partial class UnityEngineExtensions
    {
        public static System.Numerics.Quaternion ToSystemNumerics(this UnityEngine.Quaternion quaternion)
        {
            return new System.Numerics.Quaternion(quaternion.x, quaternion.y, quaternion.z, quaternion.w);
        }

        public static void ConvertToSystemNumerics(this UnityEngine.Quaternion source, ref System.Numerics.Quaternion target)
        {
            target.X = source.x;
            target.Y = source.y;
            target.Z = source.z;
            target.W = source.w;
        }
    }
}
