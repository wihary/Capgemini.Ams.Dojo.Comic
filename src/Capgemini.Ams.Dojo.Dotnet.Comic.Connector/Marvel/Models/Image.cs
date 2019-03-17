using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Capgemini.Ams.Dojo.Comic.Connector.Marvel.Models
{

    /// <summary>
    ///
    /// </summary>
    /// </summary>
    public class Image
    {
        /// <summary>
        /// The directory path of to the image.
        /// </summary>
        /// <value>The directory path of to the image.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// The file extension for the image.
        /// </summary>
        /// <value>The file extension for the image.</value>
        /// </summar = > =
        /// <value>The file extension for the image.</value>
        [DataMember(Name = "extension", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "extension")]
        public string Extension { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Image {\n");
            sb.Append("  Path: ").Append(this.Path).Append("\n");
            sb.Append("  Extension: ").Append(this.Extension).Append("\n");
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
