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
    public class Character
    {
        /// <summary>
        /// The unique ID of the character resource.
        /// </summary>
        /// <value>The unique ID of the character resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        /// <summary>
        /// The name of the character.
        /// </summary>
        /// <value>The name of the character.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A short bio or description of the character.
        /// </summary>
        /// <value>A short bio or description of the character.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The date the resource was most recently modified.
        /// </summary>
        /// <value>The date the resource was most recently modified.</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modified")]
        public object Modified { get; set; }

        /// <summary>
        /// The canonical URL identifier for this resource.
        /// </summary>
        /// <value>The canonical URL identifier for this resource.</value>
        [DataMember(Name = "resourceURI", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// A set of public web site URLs for the resource.
        /// </summary>
        /// <value>A set of public web site URLs for the resource.</value>
        [DataMember(Name = "urls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "urls")]
        public List<Url> Urls { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "thumbnail")]
        public Image Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Comics
        /// </summary>
        [DataMember(Name = "comics", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "comics")]
        public ComicList Comics { get; set; }

        /// <summary>
        /// Gets or Sets Stories
        /// </summary>
        [DataMember(Name = "stories", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stories")]
        public StoryList Stories { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "events")]
        public EventList Events { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "series")]
        public SeriesList Series { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Character {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Modified: ").Append(this.Modified).Append("\n");
            sb.Append("  ResourceURI: ").Append(this.ResourceURI).Append("\n");
            sb.Append("  Urls: ").Append(this.Urls).Append("\n");
            sb.Append("  Thumbnail: ").Append(this.Thumbnail).Append("\n");
            sb.Append("  Comics: ").Append(this.Comics).Append("\n");
            sb.Append("  Stories: ").Append(this.Stories).Append("\n");
            sb.Append("  Events: ").Append(this.Events).Append("\n");
            sb.Append("  Series: ").Append(this.Series).Append("\n");
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
