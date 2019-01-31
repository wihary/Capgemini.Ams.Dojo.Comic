namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Newtonsoft.Json;

    [DataContract]
    public class WrapperComicVine<T> : IWrapperBase<T>
    {
        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [DataMember(Name = "limit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "limit")]
        public int Limit { get; set; }

        [DataMember(Name = "offset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }

        [DataMember(Name = "number_of_page_results", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number_of_page_results")]
        public int NumberOfPage { get; set; }

        [DataMember(Name = "number_of_total_results", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "number_of_total_results")]
        public int TotalResults { get; set; }

        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status_code")]
        public int StatusCode { get; set; }

        [DataMember(Name = "results", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "results")]
        public IEnumerable<T> DataList { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceDataWrapper {\n");
            sb.Append("  Code: ").Append(this.StatusCode).Append("\n");
            sb.Append("  Error: ").Append(this.Error).Append("\n");
            sb.Append("  Limit: ").Append(this.Limit).Append("\n");
            sb.Append("  Offset: ").Append(this.Offset).Append("\n");
            sb.Append("  NumberOfPage: ").Append(this.NumberOfPage).Append("\n");
            sb.Append("  TotalResults: ").Append(this.TotalResults).Append("\n");
            sb.Append("  Data: ").Append(this.DataList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }


    }
}