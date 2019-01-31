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
    public class CreatorSummary
    {
        /// <summary>
        /// The path to the individual creator resource.
        /// </summary>
        /// <value>The path to the individual creator resource.</value>
        [DataMember(Name = "resourceURI", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// The full name of the creator.
        /// </summary>
        /// <value>The full name of the creator.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The role of the creator in the parent entity.
        /// </summary>
        /// <value>The role of the creator in the parent entity.</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatorSummary {\n");
            sb.Append("  ResourceURI: ").Append(this.ResourceURI).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Role: ").Append(this.Role).Append("\n");
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
