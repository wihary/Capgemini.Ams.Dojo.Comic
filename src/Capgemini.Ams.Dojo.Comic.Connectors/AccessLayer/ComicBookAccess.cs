namespace Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer
{
    using Capgemini.Ams.Dojo.Comic.Connectors.AccessLayer.Interface;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel;
    using Capgemini.Ams.Dojo.Comic.Model;

    internal class ComicBookAccess : BaseAccess<ComicBook>, IComicBookAccess
    {
        /// <summary>Initialize new instance of data access layer <see cref="ComicBookAccess" />.</summary>
        /// <param name="marvelClient">Marvel client.</param>
        /// <param name="comicVineClient">Comic vine client</param>
        public ComicBookAccess(MarvelClient<ComicBook> marvelClient, ComicVineClient<ComicBook> comicVineClient)
            : base(marvelClient, comicVineClient)
        {
        }
    }
}
