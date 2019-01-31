namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Helper;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories.Interface;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Parameters;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;
    using Capgemini.Ams.Dojo.Comic.Model;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;

    public class MarvelClient<T> : IConnectorClient<T> where T : class, IResourceBase
    {
        private string publicMarvelKey;

        private string privateMarvelKey;

        private readonly IFactoryMarvel<T> factory;

        private bool providerActivated;

        private int _localTimeStamp;
        private IConfiguration configuration;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public MarvelClient(IFactoryMarvel<T> factory, IConfiguration configuration)
        {
            this.configuration = configuration;
            this.factory = factory;
        }

        /// <summary>Generate the hashcode based on local timestamp, privatekey and public key</summary>
        private string HashCode
            => SecurityHelper.ComputeMd5($"{this.Timestamp}{this.privateMarvelKey}{this.publicMarvelKey}");

        /// <summary>Hold reference to client local timestamp, use to generate authentification hash for the query</summary>
        private int Timestamp
        {
            get
            {
                if (this._localTimeStamp == 0)
                {
                    this._localTimeStamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                }

                return this._localTimeStamp;
            }
        }

        public async Task<IEnumerable<T>> FetchData(ApiQuery query)
        {
            this.publicMarvelKey = this.configuration.GetValue<string>("MarvelClient:PublicKey", "ae9a60e5c5b5d4490d564ab2c43b4a29");
            this.privateMarvelKey = this.configuration.GetValue<string>("MarvelClient:PrivateKey", "f343157af1dc2f22578a1a7e903ba07ac6c8ac13");
            this.providerActivated = this.configuration.GetValue<bool>("MarvelClient:Activated", true);

            if (!this.providerActivated)
            { return new List<T>(); }

            var providerQuery = query.ConvertToProviderParameter();
            if (providerQuery.Parameters.Count == 0)
            { return new List<T>(); }

            var jsonStr = await this.CallMarvelApiAsync(providerQuery.ToQueryString(), this.factory.ApiResourceName);


            return this.factory.ConvertResource(JsonConvert.DeserializeObject(jsonStr, this.factory.TypeResource));
        }

        private async Task<string> CallMarvelApiAsync(string queryString, string resource)
        {
            using (var client = new HttpClient())
            {
                var marvelBaseUrl = this.configuration.GetValue<string>("MarvelClient:Url", "https://gateway.marvel.com:443/v1/public/");
                var marvelUrl = $"{marvelBaseUrl}{resource}?{queryString}&ts={this.Timestamp}&apikey={this.publicMarvelKey}&hash={this.HashCode}";
                var response = await client.GetAsync(marvelUrl);

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
