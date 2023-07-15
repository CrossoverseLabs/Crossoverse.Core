using Crossoverse.Core.Domain.MotionCapture.HandTracking;
using Crossoverse.Core.Infrastructure.MotionCapture;
using UnityEngine;

namespace Crossoverse.Core.Behaviour.MotionCapture.HandTracking
{
    public class HandTrackingTarget : MonoBehaviour
    {
        [SerializeField] Animator _animator;

        public bool Initialized => _initialized;
        private bool _initialized = false;

        private Transform[] _handBones = new Transform[FingerBone.FingerBoneCount];
        private Quaternion[] _initialRotations = new Quaternion[FingerBone.FingerBoneCount];

        public void Initialize()
        {
            if (_initialized) return;

            if (_animator is null)
            {
                _animator = GetComponentInChildren<Animator>();
            }

            if (_animator != null)
            {
                for (int i = 0; i < _handBones.Length; i++)
                {
                    _handBones[i] = _animator.GetBoneTransform(MotionCaptureUtility.HandBones[i]);
                    _initialRotations[i] = _handBones[i].localRotation;
                }

                _initialized = true;
            }
        }

        public void UpdateLocalRotation(in HandTrackingData data)
        {
            if (data.Joints.Length != _handBones.Length)
            {
                Debug.LogError($"[HandTrackingTarget] Does not match count - HandTrackingData.Joints.Length: {data.Joints.Length},  HandBones.Length: {_handBones.Length}");
                return;
            }

            for (var i = 0; i < _handBones.Length; i++)
            {
                var bone = _handBones[i];

                if (bone != null)
                {
                    var joint = data.Joints[i];
                    var orientation = new Quaternion(joint.Orientation.X, joint.Orientation.Y, joint.Orientation.Z, joint.Orientation.W);
                    bone.localRotation = _initialRotations[i] * orientation;
                }
            }
        }
    }
}