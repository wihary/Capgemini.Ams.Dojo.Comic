namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories
{
    using System;
    using System.Linq;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Models;
    using Capgemini.Ams.Dojo.Comic.Model;

    public class SerieFactory : FactoryBase<ComicSerie, Series>
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public SerieFactory(WrapperMarvel<Series> comicWrapper)
            : base(comicWrapper)
        {
        }

        public override string ApiResourceName => "series";

        protected override ComicSerie ConvertToApi(Series serie)
            => new ComicSerie
            {
                Id = serie.Id,
                Name = serie.Title,
                RelatedComicBookNames = serie.Comics.Items.Select(comic => comic.Name)
            };
    }
}
