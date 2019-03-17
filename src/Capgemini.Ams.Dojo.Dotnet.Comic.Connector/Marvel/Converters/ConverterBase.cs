using System;
using System.Collections.Generic;
using Capgemini.Ams.Dojo.Comic.Connector.Marvel.Models;
using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel.Converters.Interface;

namespace Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel.Converters
{
    public abstract class ConverterBase<TApi, TProvider> : IConverterMarvel<TApi>
    {
        private readonly WrapperMarvel<TProvider> resourceWrapper;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        protected ConverterBase(WrapperMarvel<TProvider> resourceWrapper) => this.resourceWrapper = resourceWrapper;

        public Type TypeResource => this.resourceWrapper.GetType();

        public abstract string ApiResourceName { get; }

        public List<TApi> ConvertResource(object deserializeObject)
        {
            var wrapper = (WrapperMarvel<TProvider>)deserializeObject;
            var result = new List<TApi>();
            foreach (var resource in wrapper.DataList)
            {
                result.Add(this.ConvertToApi(resource));
            }

            return result;
        }

        protected abstract TApi ConvertToApi(TProvider resource);
    }
}