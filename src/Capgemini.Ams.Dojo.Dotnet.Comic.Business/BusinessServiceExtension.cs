namespace Capgemini.Ams.Dojo.Dotnet.Comic.Business
{
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    ///     Classe d'extension qui sert a decrire l'ensemble des services mis a disposition par la couche business
    ///     Au runtime ces services deviennent disponibles par Injection de Dependances
    /// </summary>
    public static class BusinessServiceExtension
    {
        /// <summary>
        ///     Methode d'extension qui definit les services mis a disposition par la couche Comic.Business
        ///
        ///     Actuellement la couche metier contient une seule classe et embarque la declaration des connecteurs
        /// </summary>
        /// <param name="services">Collection contenant la description de l'ensemble des services disponible pour l'application</param>
        /// <returns>retourne la collection des services <see cref="IServiceCollection"/></returns>
        public static IServiceCollection AddBusiness(this IServiceCollection services)
            => services.AddTransient<ComicBookLogic>()
                    .AddConnectors();
    }
}