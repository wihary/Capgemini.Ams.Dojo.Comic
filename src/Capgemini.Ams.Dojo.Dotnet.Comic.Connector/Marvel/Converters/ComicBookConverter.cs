namespace Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel.Converters
{
    using System;
    using System.Linq;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Model;
    using Dojo.Comic.Connector.Marvel.Models;

    public class ComicBookConverter : ConverterBase<ComicBook, Comic>
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public ComicBookConverter(WrapperMarvel<Comic> comicWrapper)
            : base(comicWrapper)
        { }

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