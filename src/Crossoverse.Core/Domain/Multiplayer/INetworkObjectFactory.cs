namespace Crossoverse.Core.Domain.Multiplayer
{
    public interface INetworkObjectFactory
    {
        INetworkObject Create(IGuidComponent prefab);
        INetworkObject Create(IGuidComponent prefab, int instanceId);
        int NewInstanceId();
    }
}
