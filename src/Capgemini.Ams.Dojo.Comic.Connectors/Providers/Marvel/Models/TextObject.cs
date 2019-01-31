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
    public class TextObject
    {
        /// <summary>
        /// The canonical type of the text object (e.g. solicit text, preview text, etc.).
        /// </summary>
        /// <value>The canonical type of the text object (e.g. solicit text, preview text, etc.).</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The IETF language tag denoting the language the text object is written in.
        /// </summary>
        /// <value>The IETF language tag denoting the language the text object is written in.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// The text.
        /// </summary>
        /// <value>The text.</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextObject {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Language: ").Append(this.Language).Append("\n");
            sb.Append("  Text: ").Append(this.Text).Append("\n");
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
