namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Factories
{
    using System;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Models;
    using Capgemini.Ams.Dojo.Comic.Model;

    public class ComicFactory : FactoryBase<ComicBook, Issue>
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public ComicFactory(WrapperComicVine<Issue> comicWrapper)
            : base(comicWrapper)
        {
        }

        public override string ApiResourceName => "issues";

        protected override ComicBook ConvertToApi(Issue comic)
            => new ComicBook
            {
                Id = comic.Id,
                Title = comic.Name,
                IssueNumber = comic.IssueNumber,
                ParutionDate = comic.Parution ?? DateTime.MinValue,
                SerieName = comic.Serie?.Name
            };
    }
}
