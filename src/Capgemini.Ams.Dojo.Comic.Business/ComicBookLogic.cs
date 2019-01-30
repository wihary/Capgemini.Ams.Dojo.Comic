namespace Capgemini.Ams.Dojo.Comic.Business
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Capgemini.Ams.Dojo.Comic.Model;

    /// <summary>
    ///     Classe metier dediee aux actions sur la ressource 'ComicBook'
    /// </summary>
    public class ComicBookLogic
    {
        /// <summary>
        ///     Methode qui transmet une demande de requete par titre vers les API externe
        /// </summary>
        /// <param name="title">Le debut du titre du/des comics recherches</param>
        /// <returns>retourne une collection de <see cref="ComicBook"/></returns>
        public async Task<IEnumerable<ComicBook>> GetComicsByStartTitle(string title)
        {
            // Le comicContext est un point d'entree unique permet de recuperer des donnees sans avoir connaissance des sources.
            return new List<ComicBook>{
                new ComicBook {
                    Title = "This is Spartaaa !"
                }
            };
        }
    }
}
