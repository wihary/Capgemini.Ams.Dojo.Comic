namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Models
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    public class Volume
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; internal set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; internal set; }
    }
}