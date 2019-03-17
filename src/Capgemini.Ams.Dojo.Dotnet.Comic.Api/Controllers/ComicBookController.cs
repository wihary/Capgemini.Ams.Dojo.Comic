namespace Capgemini.Ams.Dojo.Dotnet.Comic.Api.Controllers
{
    using Capgemini.Ams.Dojo.Dotnet.Comic.Business;
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
        ///     Endpoint utilise pour récupérer un comicBook
        ///     Signature : /api/comicbook
        /// </summary>
        /// <returns>returns une collection de <see cref="Model.ComicBook"/></returns>
        [HttpGet]
        public async System.Threading.Tasks.Task<IActionResult> GetComicBookAsync()
        {
            return this.Ok(await this.comicBookLogic.GetComicBookAsync("Star Wars"));
            //return this.Ok(this.comicBookLogic.GetComicBook());
        }
    }
}