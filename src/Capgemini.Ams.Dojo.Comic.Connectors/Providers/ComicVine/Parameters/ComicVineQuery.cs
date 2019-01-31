namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Parameters
{
    using System.Collections.Generic;
    using System.Linq;

    public class ComicVineQuery
    {
        /// <summary>List of optional query parameter</summary>
        public List<VineBaseParameter> Parameters { get; } = new List<VineBaseParameter>();

        public ComicVineQuery AddParameter(VineBaseParameter parameter)
        {
            this.Parameters.Add(parameter);
            return this;
        }

        public string ToQueryString() => $"filter={string.Join(",", this.Parameters.Select(parameter => parameter.ToQueryString()).ToArray())}";
    }
}