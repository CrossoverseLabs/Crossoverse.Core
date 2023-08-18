namespace Crossoverse.Core.Domain
{
    public interface INetworkObjectFactory
    {
        INetworkObject Create(INetworkObject prefab);
    }
}
