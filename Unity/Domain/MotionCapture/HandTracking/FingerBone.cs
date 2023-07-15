namespace Crossoverse.Core.Domain.MotionCapture.HandTracking
{
    public enum FingerBone
    {
        Invalid = -1,
        FingerBoneStart = 0,

        // Left hand
        LeftThumbMetacarpal = FingerBoneStart + 0,
        LeftThumbProximal = FingerBoneStart + 1,
        LeftThumbDistal = FingerBoneStart + 2,
        LeftIndexProximal = FingerBoneStart + 3,
        LeftIndexIntermediate = FingerBoneStart + 4,
        LeftIndexDistal = FingerBoneStart + 5,
        LeftMiddleProximal = FingerBoneStart + 6,
        LeftMiddleIntermediate = FingerBoneStart + 7,
        LeftMiddleDistal = FingerBoneStart + 8,
        LeftRingProximal = FingerBoneStart + 9,
        LeftRingIntermediate = FingerBoneStart + 10,
        LeftRingDistal = FingerBoneStart + 11,
        LeftLittleProximal = FingerBoneStart + 12,
        LeftLittleIntermediate = FingerBoneStart + 13,
        LeftLittleDistal = FingerBoneStart + 14,

        // Right hand
        RightThumbMetacarpal = FingerBoneStart + 15,
        RightThumbProximal = FingerBoneStart + 16,
        RightThumbDistal = FingerBoneStart + 17,
        RightIndexProximal = FingerBoneStart + 18,
        RightIndexIntermediate = FingerBoneStart + 19,
        RightIndexDistal = FingerBoneStart + 20,
        RightMiddleProximal = FingerBoneStart + 21,
        RightMiddleIntermediate = FingerBoneStart + 22,
        RightMiddleDistal = FingerBoneStart + 23,
        RightRingProximal = FingerBoneStart + 24,
        RightRingIntermediate = FingerBoneStart + 25,
        RightRingDistal = FingerBoneStart + 26,
        RightLittleProximal = FingerBoneStart + 27,
        RightLittleIntermediate = FingerBoneStart + 28,
        RightLittleDistal = FingerBoneStart + 29,

        FingerBoneCount = 30,
    }
}