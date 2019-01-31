namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories
{
    using System;
    using System.Linq;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Models;
    using Capgemini.Ams.Dojo.Comic.Model;

    public class ComicFactory : FactoryBase<ComicBook, Comic>
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public ComicFactory(WrapperMarvel<Comic> comicWrapper)
            : base(comicWrapper)
        {
        }

        public override string ApiResourceName => "comics";

        protected override ComicBook ConvertToApi(Comic comic)
            => new ComicBook
            {
                Id = comic.Id,
                ParutionDate = comic.Dates.FirstOrDefault().Date ?? DateTime.MinValue,
                IssueNumber = comic.IssueNumber,
                Title = comic.Title,
                SerieName = comic.Series.Name
            };
    }
}
