namespace Capgemini.Ams.Dojo.Dotnet.Comic.Connector.QueryFilter
{
    using System.Collections.Generic;
    using System.Linq;
    using Capgemini.Ams.Dojo.Comic.Connector.QueryFilter.Parameters;

    public class ApiQuery
    {
        /// <summary>
        ///     List of optional query parameter
        /// </summary>
        public List<BaseParameter> Parameters { get; } = new List<BaseParameter>();

        public ApiQuery AddParameter(BaseParameter parameter)
        {
            this.Parameters.Add(parameter);
            return this;
        }

        public string ToQueryString() => string.Join("&", this.Parameters.Select(parameter => parameter.ToQueryString()).ToArray());
    }
}