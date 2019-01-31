namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories.Interface
{
    using System;
    using System.Collections.Generic;

    public interface IFactoryMarvel<TApi>
    {
        Type TypeResource { get; }

        string ApiResourceName { get; }

        List<TApi> ConvertResource(object deserializeObject);
    }
}
