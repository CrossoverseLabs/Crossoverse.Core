using System;
using UnityEngine;
using Crossoverse.Core.Domain.MotionCapture.EyeTracking;

namespace Crossoverse.Core.Unity.MotionCapture
{
    public class EyeTrackingTarget : MonoBehaviour
    {
        [SerializeField] Transform _head;
        [SerializeField] Transform _leftEye;
        [SerializeField] Transform _rightEye;

        public bool Initialized => _initialized;
        private bool _initialized = false;

        private Quaternion _headInitialRotation;
        private Quaternion _leftEyeInitialLocalRotation;
        private Quaternion _rightEyeInitialLocalRotation;

        public void Initialize()
        {
            if (_initialized) return;

            var animator = GetComponentInChildren<Animator>();
            if (animator != null)
            {
                if (_head is null) { _head = animator.GetBoneTransform(HumanBodyBones.Head); }
                if (_leftEye is null)  { _leftEye = animator.GetBoneTransform(HumanBodyBones.LeftEye); }
                if (_rightEye is null) { _rightEye = animator.GetBoneTransform(HumanBodyBones.RightEye); }

                _headInitialRotation = _head.rotation;
                _leftEyeInitialLocalRotation = _leftEye.localRotation;
                _rightEyeInitialLocalRotation = _rightEye.localRotation;

                _initialized = true;
            }
        }

        public void SetRotation(in EyeTrackingData eyeTrackingData)
        {
            _head.rotation = _headInitialRotation * eyeTrackingData.HeadRotation.ToUnity();
            _leftEye.localRotation = _leftEyeInitialLocalRotation * eyeTrackingData.LeftEyeLocalRotation.ToUnity();
            _rightEye.localRotation = _rightEyeInitialLocalRotation * eyeTrackingData.RightEyeLocalRotation.ToUnity();
        }
    }
}