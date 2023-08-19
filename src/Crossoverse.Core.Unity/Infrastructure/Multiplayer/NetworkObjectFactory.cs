using System;
using System.IO.Hashing;
using Crossoverse.Core.Domain.Multiplayer;
using Crossoverse.Core.Unity.Behaviour.Multiplayer;

namespace Crossoverse.Core.Unity.Infrastructure.Multiplayer
{
    public sealed class NetworkObjectFactory : INetworkObjectFactory
    {
        public INetworkObject Create(IGuidComponent prefab)
        {
            if (prefab is not GuidComponent gameObjectPrefab) return null;
            return Create(gameObjectPrefab, NewInstanceId());
        }

        public INetworkObject Create(IGuidComponent prefab, int instanceId)
        {
            if (prefab is not GuidComponent gameObjectPrefab) return null;
            return new NetworkObject(gameObjectPrefab.Guid, instanceId);
        }

        public int NewInstanceId()
        {
            return BitConverter.ToInt32(XxHash32.Hash(Guid.NewGuid().ToByteArray()));
        }
    }
}
