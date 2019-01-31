namespace Capgemini.Ams.Dojo.Comic.Connectors.Converters
{
    using System.Collections.Generic;
    using Capgemini.Ams.Dojo.Comic.Model;

    public interface IWrapperBase<T>
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        IEnumerable<T> DataList { get; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        string ToString();

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        string ToJson();
    }
}