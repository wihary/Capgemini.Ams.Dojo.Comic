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
    public class Series
    {
        /// <summary>
        /// The unique ID of the series resource.
        /// </summary>
        /// <value>The unique ID of the series resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// The canonical title of the series.
        /// </summary>
        /// <value>The canonical title of the series.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// A description of the series.
        /// </summary>
        /// <value>A description of the series.</value>
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
        /// A set of public web site URLs for the resource.
        /// </summary>
        /// <value>A set of public web site URLs for the resource.</value>
        [DataMember(Name = "urls", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "urls")]
        public List<Url> Urls { get; set; }

        /// <summary>
        /// The first year of publication for the series.
        /// </summary>
        /// <value>The first year of publication for the series.</value>
        [DataMember(Name = "startYear", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startYear")]
        public object StartYear { get; set; }

        /// <summary>
        /// The last year of publication for the series (conventionally, 2099 for ongoing series) .
        /// </summary>
        /// <value>The last year of publication for the series (conventionally, 2099 for ongoing series) .</value>
        [DataMember(Name = "endYear", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endYear")]
        public object EndYear { get; set; }

        /// <summary>
        /// The age-appropriateness rating for the series.
        /// </summary>
        /// <value>The age-appropriateness rating for the series.</value>
        [DataMember(Name = "rating", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "rating")]
        public string Rating { get; set; }

        /// <summary>
        /// The date the resource was most recently modified.
        /// </summary>
        /// <value>The date the resource was most recently modified.</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modified")]
        public object Modified { get; set; }

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
        public SeriesSummary Next { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [DataMember(Name = "previous", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "previous")]
        public SeriesSummary Previous { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Series {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  ResourceURI: ").Append(this.ResourceURI).Append("\n");
            sb.Append("  Urls: ").Append(this.Urls).Append("\n");
            sb.Append("  StartYear: ").Append(this.StartYear).Append("\n");
            sb.Append("  EndYear: ").Append(this.EndYear).Append("\n");
            sb.Append("  Rating: ").Append(this.Rating).Append("\n");
            sb.Append("  Modified: ").Append(this.Modified).Append("\n");
            sb.Append("  Thumbnail: ").Append(this.Thumbnail).Append("\n");
            sb.Append("  Comics: ").Append(this.Comics).Append("\n");
            sb.Append("  Stories: ").Append(this.Stories).Append("\n");
            sb.Append("  Events: ").Append(this.Events).Append("\n");
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
