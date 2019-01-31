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
    public class StoryList
    {
        /// <summary>
        /// The number of total available stories in this list. Will always be greater than or equal to the \"returned\" value.
        /// </summary>
        /// <value>The number of total available stories in this list. Will always be greater than or equal to the \"returned\" value.</value>
        [DataMember(Name = "available", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "available")]
        public object Available { get; set; }

        /// <summary>
        /// The number of stories returned in this collection (up to 20).
        /// </summary>
        /// <value>The number of stories returned in this collection (up to 20).</value>
        [DataMember(Name = "returned", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "returned")]
        public object Returned { get; set; }

        /// <summary>
        /// The path to the full list of stories in this collection.
        /// </summary>
        /// <value>The path to the full list of stories in this collection.</value>
        [DataMember(Name = "collectionURI", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "collectionURI")]
        public string CollectionURI { get; set; }

        /// <summary>
        /// The list of returned stories in this collection.
        /// </summary>
        /// <value>The list of returned stories in this collection.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "items")]
        public List<StorySummary> Items { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoryList {\n");
            sb.Append("  Available: ").Append(this.Available).Append("\n");
            sb.Append("  Returned: ").Append(this.Returned).Append("\n");
            sb.Append("  CollectionURI: ").Append(this.CollectionURI).Append("\n");
            sb.Append("  Items: ").Append(this.Items).Append("\n");
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
