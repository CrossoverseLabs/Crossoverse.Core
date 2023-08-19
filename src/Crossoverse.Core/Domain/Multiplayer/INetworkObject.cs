using System;

namespace Crossoverse.Core.Domain.Multiplayer
{
    public interface INetworkObject : IDisposable
    {
        Guid OriginalObjectId { get; }
        int InstanceId { get; }
    }
}
