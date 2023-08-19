using System.Numerics;
using UnityEngine;

namespace Crossoverse.Core.Unity
{
    public static partial class UnityEngineExtensions
    {
        public static System.Numerics.Vector3 ToSystemNumerics(this UnityEngine.Vector3 vector)
        {
            return new System.Numerics.Vector3(vector.x, vector.y, vector.z);
        }

        public static void ConvertToSystemNumerics(this UnityEngine.Vector3 source, ref System.Numerics.Vector3 target)
        {
            target.X = source.x;
            target.Y = source.y;
            target.Z = source.z;
        }
    }
}
