namespace Crossoverse.Core.Domain.Multiplayer
{
    public interface INetworkObjectFactory
    {
        INetworkObject Create(IGuidComponent prefab);
        int NewInstanceId();
    }
}
