#if UNIGLTF && VRM
using System;
using System.Threading;
using System.Threading.Tasks;
using Crossoverse.Core.Domain.ResourceProvider;
using Cysharp.Threading.Tasks;
using UniGLTF;
using UniVRM10;
using UnityEngine;

namespace Crossoverse.Core.Unity.Infrastructure.ResourceProvider
{
    public sealed class VrmAvatarResourceProvider : IAvatarResourceProvider<VrmAvatar>
    {
        readonly IBinaryDataProvider _binaryDataProvider;

        public VrmAvatarResourceProvider(IBinaryDataProvider binaryDataProvider)
        {
            _binaryDataProvider = binaryDataProvider;
        }

        public async UniTask<VrmAvatar> LoadAsync(string path, MaterialType materialType, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(path)) return null;

            try
            {
                IMaterialDescriptorGenerator materialGenerator = materialType switch
                {
                    MaterialType.UniversalRenderPipeline => new UrpVrm10MaterialDescriptorGenerator(),
                    _ => new BuiltInVrm10MaterialDescriptorGenerator()
                };

                var bytes = await _binaryDataProvider.LoadAsync(path, cancellationToken);
                var loadedVrm = await Vrm10.LoadBytesAsync(bytes,
                    canLoadVrm0X: true,
                    showMeshes: false,
                    materialGenerator: materialGenerator,
                    ct: cancellationToken);

                if (loadedVrm == null) return null;

                return new VrmAvatar(loadedVrm.GetComponent<RuntimeGltfInstance>());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
#endif
