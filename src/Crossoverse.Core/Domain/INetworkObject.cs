using System;

namespace Crossoverse.Core.Domain
{
    public interface INetworkObject : IDisposable
    {
        Guid Guid { get; }
    }
}
