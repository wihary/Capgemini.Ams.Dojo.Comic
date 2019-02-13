namespace Capgemini.Ams.Dojo.Donet.Comic.Api.Controllers
{
    using Capgemini.Ams.Dojo.Donet.Comic.Business;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class ComicBookController : ControllerBase
    {
        private readonly ComicBookLogic comicBookLogic;

        /// <summary>
        ///     ctor of <see cref="ComicBookController"/>
        /// </summary>
        /// <param name="comicBookLogic">Injection de Dependance : Couche metier qui supervise les actions pour les comics</param>
        public ComicBookController(ComicBookLogic comicBookLogic)
            => this.comicBookLogic = comicBookLogic;

        /// <summary>
        ///     Endpoint utilise pour recuperer un comicBook
        ///     Signature : /api/comicbook
        /// </summary>
        /// <returns>returns une collection de <see cref="Model.ComicBook"/></returns>
        [HttpGet]
        public IActionResult GetComicBook()
        {
            return this.Ok(this.comicBookLogic.GetComicBook());
        }
    }
}