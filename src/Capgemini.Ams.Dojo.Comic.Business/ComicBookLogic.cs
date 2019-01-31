namespace Capgemini.Ams.Dojo.Comic.Business
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer.Interface;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter.Parameters;
    using Capgemini.Ams.Dojo.Comic.Model;

    /// <summary>
    ///     Classe metier dediee aux actions sur la ressource 'ComicBook'
    /// </summary>
    public class ComicBookLogic
    {
        /// <summary>
        ///     Reference vers le context d'acces a la ressource 'ComicBook'
        /// </summary>
        private readonly IComicBookAccess comicContext;

        /// <summary>
        ///     ctor of <see cref="ComicBookLogic"/>
        /// </summary>
        /// <param name="comicContext">DI - Context d'acces a la ressource 'ComicBook' provenant des API externes</param>
        public ComicBookLogic(IComicBookAccess comicContext)
            => this.comicContext = comicContext;

        /// <summary>
        ///     Methode qui transmet une demande de requete par titre vers les API externe
        /// </summary>
        /// <param name="title">Le debut du titre du/des comics recherches</param>
        /// <returns>retourne une collection de <see cref="ComicBook"/></returns>
        public async Task<IEnumerable<ComicBook>> GetComicsByStartTitle(string title)
        {
            // Pour simplifier la creation de requete le composant Comic.COnnectors expose un objet unique pour declarer une requete
            var apiQuery = new ApiQuery();
            apiQuery.AddParameter(new TitleStartsWithParameter(title));

            // Le comicContext est un point d'entree unique permet de recuperer des donnees sans avoir connaissance des sources.
            return await this.comicContext.FetchData(apiQuery);
        }
    }
}
