namespace Capgemini.Ams.Dojo.Comic.Business
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer.Interface;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;
    using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter.Parameters;
    using Capgemini.Ams.Dojo.Comic.Model;

    /// <summary>
    ///     Classe metier dediee aux actions sur la ressource 'ComicAuthor'
    /// </summary>
    public class ComicAuthorLogic
    {
        /// <summary>
        ///     Reference vers le context d'acces a la ressource 'ComicAuthor'
        /// </summary>
        private readonly IAuthorAccess authorAccess;

        /// <summary>
        ///     ctor of <see cref="ComicAuthorLogic"/>
        /// </summary>
        /// <param name="authorAccess">DI - Context d'acces a la ressource 'ComicAuthor' provenant des API externes</param>
        public ComicAuthorLogic(IAuthorAccess authorAccess)
            => this.authorAccess = authorAccess;

        /// <summary>
        ///     Methode qui transmet une demande de requete par nom vers les API externe
        /// </summary>
        /// <param name="name">Le nom de l'auteur recherche</param>
        /// <returns>retourne une collection de <see cref="ComicAuthor"/></returns>
        public async Task<IEnumerable<ComicAuthor>> GetAuthorByFullName(string fullname)
        {
            var authorName = fullname.Split(',');

            // Pour simplifier la creation de requete le composant Comic.Connectors expose un objet unique pour declarer une requete
            var apiQuery = new ApiQuery();
            apiQuery.AddParameter(new AuthorByFirstNameParameter(authorName[0]));
            apiQuery.AddParameter(new AuthorByNameParameter(authorName[1]));

            // Le comicContext est un point d'entree unique permet de recuperer des donnees sans avoir connaissance des sources.
            return await this.authorAccess.FetchData(apiQuery);
        }
    }
}
