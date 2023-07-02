using System.Threading;
using System.Threading.Tasks;

namespace Crossoverse.Core.Domain.ResourceProvider
{
    public sealed class LocalFileBinaryDataProvider : IBinaryDataProvider
    {
        public async Task<byte[]> LoadAsync(string path, CancellationToken cancellationToken = default)
        {
            return await System.IO.File.ReadAllBytesAsync(path, cancellationToken);
        }
    }
}