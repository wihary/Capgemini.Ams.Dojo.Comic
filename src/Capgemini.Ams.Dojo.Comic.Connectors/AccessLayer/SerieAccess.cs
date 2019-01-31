using Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer.Interface;
using Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine;
using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel;
using Capgemini.Ams.Dojo.Comic.Model;

namespace Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer
{
    internal class SerieAccess : BaseAccess<ComicSerie>, ISerieAccess
    {
        /// <summary>Initialize new instance of data access layer <see cref="ComicBookAccess" />.</summary>
        /// <param name="marvelClient">Marvel client.</param>
        public SerieAccess(MarvelClient<ComicSerie> marvelClient)
            : base(marvelClient)
        {
        }
    }
}