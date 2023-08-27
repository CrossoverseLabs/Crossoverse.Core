using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;

namespace Crossoverse.Core.Domain.ResourceProvider
{
    public interface IAvatarResourceProvider<T> where T : IAvatarResource
    {
        UniTask<T> LoadAsync(string path, MaterialType materialType, CancellationToken cancellationToken = default);
    }
}
