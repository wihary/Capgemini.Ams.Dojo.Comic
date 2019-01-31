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
    public class Creator
    {
        /// <summary>
        /// The unique ID of the creator resource.
        /// </summary>
        /// <value>The unique ID of the creator resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        /// <summary>
        /// The first name of the creator.
        /// </summary>
        /// <value>The first name of the creator.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the creator.
        /// </summary>
        /// <value>The middle name of the creator.</value>
        [DataMember(Name = "middleName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the creator.
        /// </summary>
        /// <value>The last name of the creator.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The suffix or honorific for the creator.
        /// </summary>
        /// <value>The suffix or honorific for the creator.</value>
        [DataMember(Name = "suffix", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// The full name of the creator (a space-separated concatenation of the above four fields).
        /// </summary>
        /// <value>The full name of the creator (a space-separated concatenation of the above four fields).</value>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

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
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "series")]
        public SeriesList Series { get; set; }

        /// <summary>
        /// Gets or Sets Stories
        /// </summary>
        [DataMember(Name = "stories", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stories")]
        public StoryList Stories { get; set; }

        /// <summary>
        /// Gets or Sets Comics
        /// </summary>
        [DataMember(Name = "comics", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "comics")]
        public ComicList Comics { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "events")]
        public EventList Events { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Creator {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  FirstName: ").Append(this.FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(this.MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(this.LastName).Append("\n");
            sb.Append("  Suffix: ").Append(this.Suffix).Append("\n");
            sb.Append("  FullName: ").Append(this.FullName).Append("\n");
            sb.Append("  Modified: ").Append(this.Modified).Append("\n");
            sb.Append("  ResourceURI: ").Append(this.ResourceURI).Append("\n");
            sb.Append("  Urls: ").Append(this.Urls).Append("\n");
            sb.Append("  Thumbnail: ").Append(this.Thumbnail).Append("\n");
            sb.Append("  Series: ").Append(this.Series).Append("\n");
            sb.Append("  Stories: ").Append(this.Stories).Append("\n");
            sb.Append("  Comics: ").Append(this.Comics).Append("\n");
            sb.Append("  Events: ").Append(this.Events).Append("\n");
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
