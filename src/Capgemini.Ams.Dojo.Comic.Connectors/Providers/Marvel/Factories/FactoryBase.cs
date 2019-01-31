namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories
{
    using System;
    using System.Collections.Generic;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories.Interface;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Models;

    public abstract class FactoryBase<TApi, TProvider> : IFactoryMarvel<TApi>
    {
        private readonly IWrapperBase<TProvider> comicWrapper;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        protected FactoryBase(IWrapperBase<TProvider> resourceWrapper)
            => this.comicWrapper = resourceWrapper;

        public Type TypeResource => this.comicWrapper.GetType();

        public abstract string ApiResourceName { get; }

        public List<TApi> ConvertResource(object deserializeObject)
        {
            var wrapper = (IWrapperBase<TProvider>)deserializeObject;
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
