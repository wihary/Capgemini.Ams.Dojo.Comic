namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Factories.Interface;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Parameters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;
    using Capgemini.Ams.Dojo.Comic.Model;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;

    public class ComicVineClient<T> : IConnectorClient<T> where T : class, IResourceBase
    {
        private string publicApiKey;
        private bool providerActivated;
        private IConfiguration configuration;
        private readonly IFactoryVine<T> factory;

        public ComicVineClient(IFactoryVine<T> factory, IConfiguration configuration)
        {
            this.configuration = configuration;
            this.factory = factory;
        }

        public async Task<IEnumerable<T>> FetchData(ApiQuery query)
        {
            this.publicApiKey = this.configuration.GetValue<string>("ComicVineClient:PublicKey", "57fc328401d9fabd732e98ae0cbb8d28ec65aa64");
            this.providerActivated = this.configuration.GetValue<bool>("ComicVineClient:Activated", false);

            if (!this.providerActivated)
            { return new List<T>(); }

            var providerQuery = query.ConvertToProviderParameter();
            if (providerQuery.Parameters.Count == 0)
            { return new List<T>(); }

            var jsonResult = await this.CallComicVineApiAsync(providerQuery.ToQueryString(), this.factory.ApiResourceName);

            return this.factory.ConvertResource(JsonConvert.DeserializeObject(jsonResult, this.factory.TypeResource));
        }

        private async Task<string> CallComicVineApiAsync(string queryString, string resource)
        {
            var apiBaseUrl = this.configuration.GetValue<string>("ComicVineClient:Url", "https://comicvine.gamespot.com/api/");
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "C# App");
                var response = await client.GetAsync($"{apiBaseUrl}{resource}/?api_key={this.publicApiKey}&format=json&{queryString}");

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
            }

            return null;
        }
    }
}
