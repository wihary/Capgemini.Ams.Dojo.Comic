namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Parameters
{
    /// <summary>Base class for API query parameter</summary>
    public abstract class MarvelBaseParameter
    {
        /// <summary>Contains value for the parameter filter</summary>
        public string value { get; }

        /// <summary></summary>
        /// <param name="parameterValue"></param>
        protected MarvelBaseParameter(string parameterValue)
            => this.value = parameterValue;

        /// <summary>Specify the webService name of the parameter</summary>
        public abstract string Name { get; }

        public string ToQueryString()
            => $"{this.Name}={this.value}";
    }
}
