namespace Capgemini.Ams.Dojo.Comic.Connectors
{
    using Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer;
    using Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer.Interface;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine;
    using Vinefactories = Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Factories;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel;
    using MarvelFactories = Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Models;
    using Capgemini.Ams.Dojo.Comic.Model;

    using Microsoft.Extensions.DependencyInjection;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Models;

    public static class ConnectorServiceExtension
    {
        public static IServiceCollection AddConnectors(this IServiceCollection services)
            => services.AddComicsProviders()
                       .AddMarvelFactory()
                       .AddVineFactory()
                       .AddResourceWrappers()
                       .AddTransient<IComicBookAccess, ComicBookAccess>()
                       .AddTransient<ISerieAccess, SerieAccess>()
                       .AddTransient<IAuthorAccess, AuthorAcess>();

        private static IServiceCollection AddComicsProviders(this IServiceCollection services)
            => services.AddTransient(typeof(MarvelClient<>))
                       .AddTransient(typeof(ComicVineClient<>));

        private static IServiceCollection AddMarvelFactory(this IServiceCollection services)
            => services.AddTransient<MarvelFactories.Interface.IFactoryMarvel<ComicBook>, MarvelFactories.ComicFactory>()
                    .AddTransient<MarvelFactories.Interface.IFactoryMarvel<ComicSerie>, MarvelFactories.SerieFactory>()
                    .AddTransient<MarvelFactories.Interface.IFactoryMarvel<ComicAuthor>, MarvelFactories.CreatorFactory>();

        private static IServiceCollection AddVineFactory(this IServiceCollection services)
            => services.AddTransient<Vinefactories.Interface.IFactoryVine<ComicBook>, Vinefactories.ComicFactory>()
                    .AddTransient<Vinefactories.Interface.IFactoryVine<ComicSerie>, Vinefactories.SerieFactory>();

        private static IServiceCollection AddResourceWrappers(this IServiceCollection services)
            => services.AddTransient(typeof(WrapperMarvel<>))
                       .AddTransient(typeof(WrapperComicVine<>));
    }
}
