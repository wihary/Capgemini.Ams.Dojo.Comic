using System.Threading.Tasks;
using Capgemini.Ams.Dojo.Comic.Business;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.Ams.Dojo.Comic.Api.Controllers
{
     [Route("api/[Controller]")]
    public class AuthorController : ControllerBase
    {
        
        private readonly ComicAuthorLogic authorLogic;

        /// <summary>
        ///     ctor of <see cref="AuthorController"/>
        /// </summary>
        /// <param name="authorLogic">Injection de Dependance : Couche metier qui supervise les actions pour les auteurs</param>
        public AuthorController(ComicAuthorLogic authorLogic)
            => this.authorLogic = authorLogic;

        /// <summary>
        ///     Endpoint utilise pour effectuer une recherche d'auteur via leur nom complet
        ///     Signature : /api/author?name=
        /// </summary>
        /// <param name="fullname"></param>
        /// <returns>returns une collection de <see cref="Model.ComicAuthor"/></returns>
        [HttpGet]
        public async Task<IActionResult> GetByFullname([FromQuery]string fullname)
        {
            return this.Ok(await this.authorLogic.GetAuthorByFullName(fullname));
        }
    }
}