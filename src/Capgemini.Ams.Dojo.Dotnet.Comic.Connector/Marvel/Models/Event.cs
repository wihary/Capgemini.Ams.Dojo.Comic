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
    [DataContract]
    public class Event
    {
        /// <summary>
        /// The unique ID of the event resource.
        /// </summary>
        /// <value>The unique ID of the event resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public object Id { get; set; }

        /// <summary>
        /// The title of the event.
        /// </summary>
        /// <value>The title of the event.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// A description of the event.
        /// </summary>
        /// <value>A description of the event.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The canonical URL identifier for this resource.
        /// </summary>
        /// <value>The canonical URL identifier for this resource.</value>
        [DataMember(Name = "resourceURI", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// A set of public web site URLs for the event.
        /// </summary>
        /// <value>A set of public web site URLs for the event.</value>
        [DataMember(Name = "urls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "urls")]
        public List<Url> Urls { get; set; }

        /// <summary>
        /// The date the resource was most recently modified.
        /// </summary>
        /// <value>The date the resource was most recently modified.</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modified")]
        public object Modified { get; set; }

        /// <summary>
        /// The date of publication of the first issue in this event.
        /// </summary>
        /// <value>The date of publication of the first issue in this event.</value>
        [DataMember(Name = "start", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "start")]
        public object Start { get; set; }

        /// <summary>
        /// The date of publication of the last issue in this event.
        /// </summary>
        /// <value>The date of publication of the last issue in this event.</value>
        [DataMember(Name = "end", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "end")]
        public object End { get; set; }

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
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "series")]
        public SeriesList Series { get; set; }

        /// <summary>
        /// Gets or Sets Characters
        /// </summary>
        [DataMember(Name = "characters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "characters")]
        public CharacterList Characters { get; set; }

        /// <summary>
        /// Gets or Sets Creators
        /// </summary>
        [DataMember(Name = "creators", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creators")]
        public CreatorList Creators { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "next")]
        public EventSummary Next { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [DataMember(Name = "previous", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previous")]
        public EventSummary Previous { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  ResourceURI: ").Append(this.ResourceURI).Append("\n");
            sb.Append("  Urls: ").Append(this.Urls).Append("\n");
            sb.Append("  Modified: ").Append(this.Modified).Append("\n");
            sb.Append("  Start: ").Append(this.Start).Append("\n");
            sb.Append("  End: ").Append(this.End).Append("\n");
            sb.Append("  Thumbnail: ").Append(this.Thumbnail).Append("\n");
            sb.Append("  Comics: ").Append(this.Comics).Append("\n");
            sb.Append("  Stories: ").Append(this.Stories).Append("\n");
            sb.Append("  Series: ").Append(this.Series).Append("\n");
            sb.Append("  Characters: ").Append(this.Characters).Append("\n");
            sb.Append("  Creators: ").Append(this.Creators).Append("\n");
            sb.Append("  Next: ").Append(this.Next).Append("\n");
            sb.Append("  Previous: ").Append(this.Previous).Append("\n");
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
