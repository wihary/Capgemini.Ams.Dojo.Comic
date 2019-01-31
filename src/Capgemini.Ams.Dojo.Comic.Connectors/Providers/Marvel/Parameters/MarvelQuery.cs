namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Parameters
{
    using System.Collections.Generic;
    using System.Linq;

    public class MarvelQuery
    {
        /// <summary>List of optional query parameter</summary>
        public List<MarvelBaseParameter> Parameters { get; } = new List<MarvelBaseParameter>();

        public MarvelQuery AddParameter(MarvelBaseParameter parameter)
        {
            this.Parameters.Add(parameter);
            return this;
        }

        public string ToQueryString() => $"{string.Join("&", this.Parameters.Select(parameter => parameter.ToQueryString()).ToArray())}";
    }
}