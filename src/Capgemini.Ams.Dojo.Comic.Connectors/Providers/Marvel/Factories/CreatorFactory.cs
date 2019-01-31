namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Factories
{
    using Capgemini.Ams.Dojo.Comic.Connectors.Converters;
    using Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Models;
    using Capgemini.Ams.Dojo.Comic.Model;

    public class CreatorFactory : FactoryBase<ComicAuthor, Creator>
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public CreatorFactory(WrapperMarvel<Creator> comicWrapper)
            : base(comicWrapper)
        {
        }

        public override string ApiResourceName => "creators";

        protected override ComicAuthor ConvertToApi(Creator comic)
            => new ComicAuthor
            {
                FirstName = comic.FirstName,
                MiddleName = comic.MiddleName,
                LastName = comic.LastName,
                FullName = comic.FullName
            };
    }
}
