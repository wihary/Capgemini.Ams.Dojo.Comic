namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Factories
{
    using System;
    using System.Linq;
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Models;
    using Capgemini.Ams.Dojo.Comic.Model;

    public class SerieFactory : FactoryBase<ComicSerie, Volume>
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public SerieFactory(WrapperComicVine<Volume> serieWrapper)
            : base(serieWrapper)
        {
        }

        public override string ApiResourceName => "volumes";

        protected override ComicSerie ConvertToApi(Volume serie)
            => new ComicSerie
            {
                Id = serie.Id,
                Name = serie.Name,
            };
    }
}
