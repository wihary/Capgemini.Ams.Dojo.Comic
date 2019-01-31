using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Models
{

    /// <summary>
    ///
    /// </summary>
    [DataContract]
    public class Url
    {
        /// <summary>
        /// A text identifier for the URL.
        /// </summary>
        /// <value>A text identifier for the URL.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// A full URL (including scheme, domain, and path).
        /// </summary>
        /// <value>A full URL (including scheme, domain, and path).</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "url")]
        public string _Url { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Url {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  _Url: ").Append(this._Url).Append("\n");
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
