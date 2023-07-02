using System.Threading;
using System.Threading.Tasks;

namespace Crossoverse.Core.Domain.ResourceProvider
{
    public interface IBinaryDataProvider
    {
        Task<byte[]> LoadAsync(string path, CancellationToken cancellationToken = default);
    }
}