using Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer.Interface;
using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel;
using Capgemini.Ams.Dojo.Comic.Model;

namespace Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer
{
    public class AuthorAcess : BaseAccess<ComicAuthor>, IAuthorAccess
    {
        /// <summary>Initialize new instance of data access layer <see cref="ComicBookAccess" />.</summary>
        /// <param name="marvelClient">Marvel client.</param>
        public AuthorAcess(MarvelClient<ComicAuthor> marvelClient)
            : base(marvelClient)
        {
        }
    }
}