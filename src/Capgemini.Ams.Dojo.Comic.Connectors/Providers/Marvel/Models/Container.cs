using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Models
{
    using System.ComponentModel;

    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Container<T>
    {
        /// <summary>
        /// The requested offset (number of skipped results) of the call.
        /// </summary>
        /// <value>The requested offset (number of skipped results) of the call.</value>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "offset")]
        public object Offset { get; set; }

        /// <summary>
        /// The requested result limit.
        /// </summary>
        /// <value>The requested result limit.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "limit")]
        public object Limit { get; set; }

        /// <summary>
        /// The total number of resources available given the current filter set.
        /// </summary>
        /// <value>The total number of resources available given the current filter set.</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "total")]
        public object Total { get; set; }

        /// <summary>
        /// The total number of results returned by this call.
        /// </summary>
        /// <value>The total number of results returned by this call.</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "count")]
        public object Count { get; set; }

        /// <summary>
        /// The list of comics returned by the call
        /// </summary>
        /// <value>The list of comics returned by the call</value>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "results")]
        public List<T> Results { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComicDataContainer {\n");
            sb.Append("  Offset: ").Append(this.Offset).Append("\n");
            sb.Append("  Limit: ").Append(this.Limit).Append("\n");
            sb.Append("  Total: ").Append(this.Total).Append("\n");
            sb.Append("  Count: ").Append(this.Count).Append("\n");
            sb.Append("  Results: ").Append(this.Results).Append("\n");
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
