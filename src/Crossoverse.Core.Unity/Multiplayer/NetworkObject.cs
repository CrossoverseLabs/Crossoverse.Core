using System;
using Crossoverse.Core.Domain.Multiplayer;
using UnityEngine;

namespace Crossoverse.Core.Unity.Multiplayer
{
    public class NetworkObject : MonoBehaviour, INetworkObject
    {
        public Guid OriginalObjectId { get; }
        public int InstanceId { get; set; }

        public NetworkObject(Guid originalObjectId, int instanceId)
        {
            OriginalObjectId = originalObjectId;
            InstanceId = instanceId;
        }

        public void Dispose()
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}
