namespace Capgemini.Ams.Dojo.Comic.Api.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Capgemini.Ams.Dojo.Comic.Business;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;

    /*
        ### AJOUTER DES FONCTIONS A L'API ###

            En l'etat l'API permet simplement de requeter une ou plusieurs source externes pour recuperer une liste de Comics via leur debut de titre

            L'idee du DOJO est d'aller plus loin et d'ajouter les features suivantes :
                - Recuperer une ou plusieurs serie de comics (exemple : Avengers (2012 - 2015) ou Star Wars (2015 - Present))
                - Recuperer l'ID ou le titre des comics qui font partie de cette serie
                - Pouvoir recuperer les informations detaillees d'un comics
                - Lier la recuperation des auteurs a un comics
    */

    /// <summary>
    ///     API controller qui definit l'ensemble des endpoints sous la route api/comic
    /// </summary>
    [Route("api/[Controller]")]
    public class ComicController : ControllerBase
    {
        private readonly ComicBookLogic comicBookLogic;

        /// <summary>
        ///     ctor of <see cref="ComicController"/>
        /// </summary>
        /// <param name="comicBookLogic">Injection de Dependance : Couche metier qui supervise les actions pour les comics</param>
        public ComicController(ComicBookLogic comicBookLogic)
            => this.comicBookLogic = comicBookLogic;

        /// <summary>
        ///     Endpoint utilise pour effectuer une recher de comics via le debut de leur titre
        ///     Signature : /api/comic?title=
        /// </summary>
        /// <param name="title"></param>
        /// <returns>returns une collection de <see cref="Model.ComicBook"/></returns>
        [HttpGet]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 30)]
        [EnableCors("AllowAllOrigin")]
        public async Task<IActionResult> GetByTitle([FromQuery]string title)
        {
            /*
                ### GESTION DES ERREURS ###

                    Implementer une logique permettant de correctement gerer les erreurs
                    Le client doit recevoir un message clair du probleme et non une stacktrace
             */

            return this.Ok(await this.comicBookLogic.GetComicsByStartTitle(title));
        }
    }
}
