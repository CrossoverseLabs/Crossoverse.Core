using System.Threading;
using System.Threading.Tasks;

namespace Crossoverse.Core.Domain.ResourceProvider
{
    public interface IAvatarResourceProvider
    {
        Task<UnityEngine.Animator> LoadAsync(string path, CancellationToken cancellationToken = default);
    }
}