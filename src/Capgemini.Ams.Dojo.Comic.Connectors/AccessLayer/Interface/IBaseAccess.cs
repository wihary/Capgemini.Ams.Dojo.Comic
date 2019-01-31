namespace Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer.Interface
{
    using Capgemini.Ams.Dojo.Comic.Model;

    public interface IBaseAccess<TResource> : IConnectorClient<TResource> where TResource : class, IResourceBase
    {
    }
}
