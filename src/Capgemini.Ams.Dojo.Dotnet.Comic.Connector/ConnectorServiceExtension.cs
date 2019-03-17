namespace Capgemini.Ams.Dojo.Dotnet.Comic.Connector
{
    using Capgemini.Ams.Dojo.Comic.Connector.Marvel.Models;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel.Converters;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel.Converters.Interface;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Model;
    using Microsoft.Extensions.DependencyInjection;

    public static class ConnectorServiceExtension
    {
        public static IServiceCollection AddConnectors(this IServiceCollection services)
        {
            services.AddTransient(typeof(MarvelClient<>))
                    .AddTransient(typeof(WrapperMarvel<>))
                    .AddTransient<IConverterMarvel<ComicBook>, ComicBookConverter>();
            return services;
        }
    }
}