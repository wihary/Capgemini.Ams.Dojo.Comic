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
    public class WrapperMarvel<T>
    {
        /// <summary>
        /// The HTTP status code of the returned result.
        /// </summary>
        /// <value>The HTTP status code of the returned result.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public object Code { get; set; }

        /// <summary>
        /// A string description of the call status.
        /// </summary>
        /// <value>A string description of the call status.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// The copyright notice for the returned result.
        /// </summary>
        /// <value>The copyright notice for the returned result.</value>
        [DataMember(Name = "copyright", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// The attribution notice for this result.  Please display either this notice or the contents of the attributionHTML field on all screens which contain data from the Marvel Comics API.
        /// </summary>
        /// <value>The attribution notice for this result.  Please display either this notice or the contents of the attributionHTML field on all screens which contain data from the Marvel Comics API.</value>
        [DataMember(Name = "attributionText", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attributionText")]
        public string AttributionText { get; set; }

        /// <summary>
        /// An HTML representation of the attribution notice for this result.  Please display either this notice or the contents of the attributionText field on all screens which contain data from the Marvel Comics API.
        /// </summary>
        /// <value>An HTML representation of the attribution notice for this result.  Please display either this notice or the contents of the attributionText field on all screens which contain data from the Marvel Comics API.</value>
        [DataMember(Name = "attributionHTML", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attributionHTML")]
        public string AttributionHTML { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "data")]
        public Container<T> Data { get; set; }

        public IEnumerable<T> DataList { get => this.Data.Results; }

        /// <summary>
        /// A digest value of the content returned by the call.
        /// </summary>
        /// <value>A digest value of the content returned by the call.</value>
        [DataMember(Name = "etag", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComicDataWrapper {\n");
            sb.Append("  Code: ").Append(this.Code).Append("\n");
            sb.Append("  Status: ").Append(this.Status).Append("\n");
            sb.Append("  Copyright: ").Append(this.Copyright).Append("\n");
            sb.Append("  AttributionText: ").Append(this.AttributionText).Append("\n");
            sb.Append("  AttributionHTML: ").Append(this.AttributionHTML).Append("\n");
            sb.Append("  Data: ").Append(this.Data).Append("\n");
            sb.Append("  Etag: ").Append(this.Etag).Append("\n");
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
