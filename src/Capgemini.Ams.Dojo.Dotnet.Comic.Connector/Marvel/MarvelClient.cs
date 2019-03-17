namespace Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Helper;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel.Converters.Interface;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.QueryFilter;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Model;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;

    public class MarvelClient<T> where T : class, IResourceBase
    {
        private string publicMarvelKey;

        private string privateMarvelKey;

        private bool providerActivated;

        private int _localTimeStamp;
        private readonly IConverterMarvel<T> converter;
        private IConfiguration configuration;

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object"></see> class.
        /// </summary>
        public MarvelClient(IConverterMarvel<T> converter, IConfiguration configuration)
        {
            this.converter = converter;
            this.configuration = configuration;
        }

        /// <summary>
        ///     Generate the hashcode based on local timestamp, privatekey and public key
        /// </summary>
        private string HashCode => SecurityHelper.ComputeMd5($"{this.Timestamp}{this.privateMarvelKey}{this.publicMarvelKey}");

        /// <summary> 
        ///     Held reference to client local timestamp, use to generate authentification hash for the query
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> FetchData(ApiQuery query)
        {
            this.publicMarvelKey = this.configuration.GetValue<string>("MarvelClient:PublicKey", "ae9a60e5c5b5d4490d564ab2c43b4a29");
            this.privateMarvelKey = this.configuration.GetValue<string>("MarvelClient:PrivateKey", "f343157af1dc2f22578a1a7e903ba07ac6c8ac13");

            var jsonStr = await this.CallMarvelApiAsync(query.ToQueryString(), this.converter.ApiResourceName);

            return this.converter.ConvertResource(JsonConvert.DeserializeObject(jsonStr, this.converter.TypeResource));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="queryString"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
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