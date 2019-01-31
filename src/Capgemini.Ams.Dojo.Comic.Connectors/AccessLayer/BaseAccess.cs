namespace Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;
    using Capgemini.Ams.Dojo.Comic.Model;

    public abstract class BaseAccess<TResource> : IConnectorClient<TResource> where TResource : class, IResourceBase
    {
        private readonly IEnumerable<IConnectorClient<TResource>> clients;

        protected BaseAccess(params IConnectorClient<TResource>[] clients) => this.clients = clients;

        public async Task<IEnumerable<TResource>> FetchData(ApiQuery query)
        {
            var result = new List<TResource>();
            foreach (var client in this.clients)
            {
                result.AddRange(await client.FetchData(query));
            }
            return result;
        }
    }
}
