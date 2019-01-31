namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Factories.Interface
{
    using System;
    using System.Collections.Generic;

    public interface IFactoryVine<TApi>
    {
        Type TypeResource { get; }

        string ApiResourceName { get; }

        List<TApi> ConvertResource(object deserializeObject);
    }
}
