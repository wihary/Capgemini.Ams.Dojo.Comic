namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Models
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    [DataContract]
    public class Issue
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; internal set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [DataMember(Name = "cover_date", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "cover_date")]
        public DateTime? Parution { get; internal set; }

        [DataMember(Name = "issue_number", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "issue_number")]
        public int IssueNumber { get; internal set; }

        [DataMember(Name = "volume", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "volume")]
        public Volume Serie { get; internal set; }
    }
}