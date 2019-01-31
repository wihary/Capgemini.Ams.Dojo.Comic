namespace Capgemini.Ams.Dojo.Comic.Business
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer.Interface;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter.Parameters;
    using Capgemini.Ams.Dojo.Comic.Model;

    /// <summary>
    ///     Classe metier dediee aux actions sur la ressource 'ComicBook'
    /// </summary>
    public class SerieLogic
    {
        /// <summary>
        ///     Reference vers le context d'acces a la ressource 'ComicBook'
        /// </summary>
        private readonly ISerieAccess serieContext;
        private readonly IComicBookAccess comicBookAccess;

        /// <summary>
        ///     ctor of <see cref="SerieLogic"/>
        /// </summary>
        /// <param name="serieContext">DI - Context d'acces a la ressource 'ComicSerie' provenant des API externes</param>
        /// <param name="comicBookAccess">DI - Context d'acces a la ressource 'ComicBook' provenant des API externes</param>
        public SerieLogic(ISerieAccess serieContext, IComicBookAccess comicBookAccess)
        {
            this.serieContext = serieContext;
            this.comicBookAccess = comicBookAccess;
        }

        /// <summary>
        ///     Methode qui transmet une demande de requete par titre vers les API externe
        /// </summary>
        /// <param name="title">Le debut du titre du/des series recherches</param>
        /// <returns>retourne une collection de <see cref="ComicSerie"/></returns>
        public async Task<IEnumerable<ComicSerie>> GetComicsByStartTitle(string title)
        {
            // Pour simplifier la creation de requete le composant Comic.COnnectors expose un objet unique pour declarer une requete
            var apiQuery = new ApiQuery();
            apiQuery.AddParameter(new SerieTitleParameter(title));

            // Le comicContext est un point d'entree unique permet de recuperer des donnees sans avoir connaissance des sources.
            var result = await this.serieContext.FetchData(apiQuery);

            return result;
        }
    }
}
