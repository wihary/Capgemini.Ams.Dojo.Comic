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
    public class Comic
    {
        /// <summary>
        /// The unique ID of the comic resource.
        /// </summary>
        /// <value>The unique ID of the comic resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// The ID of the digital comic representation of this comic. Will be 0 if the comic is not available digitally.
        /// </summary>
        /// <value>The ID of the digital comic representation of this comic. Will be 0 if the comic is not available digitally.</value>
        [DataMember(Name = "digitalId", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "digitalId")]
        public int DigitalId { get; set; }

        /// <summary>
        /// The canonical title of the comic.
        /// </summary>
        /// <value>The canonical title of the comic.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The number of the issue in the series (will generally be 0 for collection formats).
        /// </summary>
        /// <value>The number of the issue in the series (will generally be 0 for collection formats).</value>
        [DataMember(Name = "issueNumber", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "issueNumber")]
        public int IssueNumber { get; set; }

        /// <summary>
        /// If the issue is a variant (e.g. an alternate cover, second printing, or director’s cut), a text description of the variant.
        /// </summary>
        /// <value>If the issue is a variant (e.g. an alternate cover, second printing, or director’s cut), a text description of the variant.</value>
        [DataMember(Name = "variantDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "variantDescription")]
        public string VariantDescription { get; set; }

        /// <summary>
        /// The preferred description of the comic.
        /// </summary>
        /// <value>The preferred description of the comic.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The date the resource was most recently modified.
        /// </summary>
        /// <value>The date the resource was most recently modified.</value>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "modified")]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// The ISBN for the comic (generally only populated for collection formats).
        /// </summary>
        /// <value>The ISBN for the comic (generally only populated for collection formats).</value>
        [DataMember(Name = "isbn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isbn")]
        public string Isbn { get; set; }

        /// <summary>
        /// The UPC barcode number for the comic (generally only populated for periodical formats).
        /// </summary>
        /// <value>The UPC barcode number for the comic (generally only populated for periodical formats).</value>
        [DataMember(Name = "upc", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "upc")]
        public string Upc { get; set; }

        /// <summary>
        /// The Diamond code for the comic.
        /// </summary>
        /// <value>The Diamond code for the comic.</value>
        [DataMember(Name = "diamondCode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "diamondCode")]
        public string DiamondCode { get; set; }

        /// <summary>
        /// The EAN barcode for the comic.
        /// </summary>
        /// <value>The EAN barcode for the comic.</value>
        [DataMember(Name = "ean", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ean")]
        public string Ean { get; set; }

        /// <summary>
        /// The ISSN barcode for the comic.
        /// </summary>
        /// <value>The ISSN barcode for the comic.</value>
        [DataMember(Name = "issn", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "issn")]
        public string Issn { get; set; }

        /// <summary>
        /// The publication format of the comic e.g. comic, hardcover, trade paperback.
        /// </summary>
        /// <value>The publication format of the comic e.g. comic, hardcover, trade paperback.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "format")]
        public string Format { get; set; }

        /// <summary>
        /// The number of story pages in the comic.
        /// </summary>
        /// <value>The number of story pages in the comic.</value>
        [DataMember(Name = "pageCount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pageCount")]
        public int PageCount { get; set; }

        /// <summary>
        /// A set of descriptive text blurbs for the comic.
        /// </summary>
        /// <value>A set of descriptive text blurbs for the comic.</value>
        [DataMember(Name = "textObjects", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "textObjects")]
        public List<TextObject> TextObjects { get; set; }

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
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name = "series", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "series")]
        public SeriesSummary Series { get; set; }

        /// <summary>
        /// A list of variant issues for this comic (includes the \"original\" issue if the current issue is a variant).
        /// </summary>
        /// <value>A list of variant issues for this comic (includes the \"original\" issue if the current issue is a variant).</value>
        [DataMember(Name = "variants", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "variants")]
        public List<ComicSummary> Variants { get; set; }

        /// <summary>
        /// A list of collections which include this comic (will generally be empty if the comic's format is a collection).
        /// </summary>
        /// <value>A list of collections which include this comic (will generally be empty if the comic's format is a collection).</value>
        [DataMember(Name = "collections", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "collections")]
        public List<ComicSummary> Collections { get; set; }

        /// <summary>
        /// A list of issues collected in this comic (will generally be empty for periodical formats such as \"comic\" or \"magazine\").
        /// </summary>
        /// <value>A list of issues collected in this comic (will generally be empty for periodical formats such as \"comic\" or \"magazine\").</value>
        [DataMember(Name = "collectedIssues", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "collectedIssues")]
        public List<ComicSummary> CollectedIssues { get; set; }

        /// <summary>
        /// A list of key dates for this comic.
        /// </summary>
        /// <value>A list of key dates for this comic.</value>
        [DataMember(Name = "dates", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dates")]
        public List<ComicDate> Dates { get; set; }

        /// <summary>
        /// A list of prices for this comic.
        /// </summary>
        /// <value>A list of prices for this comic.</value>
        [DataMember(Name = "prices", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "prices")]
        public List<ComicPrice> Prices { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "thumbnail")]
        public Image Thumbnail { get; set; }

        /// <summary>
        /// A list of promotional images associated with this comic.
        /// </summary>
        /// <value>A list of promotional images associated with this comic.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or Sets Creators
        /// </summary>
        [DataMember(Name = "creators", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "creators")]
        public CreatorList Creators { get; set; }

        /// <summary>
        /// Gets or Sets Characters
        /// </summary>
        [DataMember(Name = "characters", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "characters")]
        public CharacterList Characters { get; set; }

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
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Comic {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  DigitalId: ").Append(this.DigitalId).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  IssueNumber: ").Append(this.IssueNumber).Append("\n");
            sb.Append("  VariantDescription: ").Append(this.VariantDescription).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Modified: ").Append(this.Modified).Append("\n");
            sb.Append("  Isbn: ").Append(this.Isbn).Append("\n");
            sb.Append("  Upc: ").Append(this.Upc).Append("\n");
            sb.Append("  DiamondCode: ").Append(this.DiamondCode).Append("\n");
            sb.Append("  Ean: ").Append(this.Ean).Append("\n");
            sb.Append("  Issn: ").Append(this.Issn).Append("\n");
            sb.Append("  Format: ").Append(this.Format).Append("\n");
            sb.Append("  PageCount: ").Append(this.PageCount).Append("\n");
            sb.Append("  TextObjects: ").Append(this.TextObjects).Append("\n");
            sb.Append("  ResourceURI: ").Append(this.ResourceURI).Append("\n");
            sb.Append("  Urls: ").Append(this.Urls).Append("\n");
            sb.Append("  Series: ").Append(this.Series).Append("\n");
            sb.Append("  Variants: ").Append(this.Variants).Append("\n");
            sb.Append("  Collections: ").Append(this.Collections).Append("\n");
            sb.Append("  CollectedIssues: ").Append(this.CollectedIssues).Append("\n");
            sb.Append("  Dates: ").Append(this.Dates).Append("\n");
            sb.Append("  Prices: ").Append(this.Prices).Append("\n");
            sb.Append("  Thumbnail: ").Append(this.Thumbnail).Append("\n");
            sb.Append("  Images: ").Append(this.Images).Append("\n");
            sb.Append("  Creators: ").Append(this.Creators).Append("\n");
            sb.Append("  Characters: ").Append(this.Characters).Append("\n");
            sb.Append("  Stories: ").Append(this.Stories).Append("\n");
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
