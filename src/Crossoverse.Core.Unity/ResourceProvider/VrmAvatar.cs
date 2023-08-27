#if UNIGLTF
using Crossoverse.Core.Domain.ResourceProvider;
using UniGLTF;
using UnityEngine;

namespace Crossoverse.Core.Unity.Infrastructure.ResourceProvider
{
    public sealed class VrmAvatar : IAvatarResource
    {
        public Animator Animator { get; }

        private readonly RuntimeGltfInstance _instance;

        public VrmAvatar(RuntimeGltfInstance instance)
        {
            _instance = instance;
            Animator = instance.GetComponent<Animator>();
        }

        public void Dispose()
        {
            _instance?.Dispose();
        }

        public void ShowMeshes()
        {
            _instance?.ShowMeshes();
        }

        public void EnableUpdateWhenOffscreen()
        {
            _instance?.EnableUpdateWhenOffscreen();
        }
    }
}
#endif
