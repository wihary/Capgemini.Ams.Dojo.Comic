namespace Capgemini.Ams.Dojo.Comic.Api.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Capgemini.Ams.Dojo.Comic.Business;

    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    ///     API controller qui definit l'ensemble des endpoints sous la route api/serie
    /// </summary>
    [Route("api/[Controller]")]
    public class SerieController : ControllerBase
    {
        private readonly SerieLogic serieLogic;

        /// <summary>
        ///     ctor of <see cref="SerieController"/>
        /// </summary>
        /// <param name="serieLogic">Injection de Dependance : Couche metier qui supervise les actions pour les series</param>
        public SerieController(SerieLogic serieLogic)
            => this.serieLogic = serieLogic;

        /// <summary>
        ///     Endpoint utilise pour effectuer une recherche de series via le debut de leur titre
        ///     Signature : /api/serie?title=
        /// </summary>
        /// <param name="title"></param>
        /// <returns>returns une collection de <see cref="Model.ComicSerie"/></returns>
        [HttpGet]
        [ResponseCache(VaryByHeader = "User-Agent", Duration = 30)]
        public async Task<IActionResult> GetByTitle([FromQuery]string title)
        {
            return this.Ok(await this.serieLogic.GetComicsByStartTitle(title));
        }
    }
}
