using System;
using System.Collections.Generic;

namespace Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel.Converters.Interface
{
    public interface IConverterMarvel<TApi>
    {
        Type TypeResource { get; }

        string ApiResourceName { get; }

        List<TApi> ConvertResource(object deserializeObject);     
    }
}