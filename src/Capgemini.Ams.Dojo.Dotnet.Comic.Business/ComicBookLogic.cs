namespace Capgemini.Ams.Dojo.Dotnet.Comic.Business
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Capgemini.Ams.Dojo.Comic.Connector.QueryFilter.Parameters;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.Marvel;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Connector.QueryFilter;
    using Capgemini.Ams.Dojo.Dotnet.Comic.Model;

    public class ComicBookLogic
    {
        private readonly MarvelClient<ComicBook> client;

        public ComicBookLogic(MarvelClient<ComicBook> client) => this.client = client;

        public ComicBook GetComicBook() => new ComicBook
        {
            Id = 42,
            Title = "This is a ComicBook title",
            ParutionDate = DateTime.Now
        };

        /// <summary>
        ///     Methode qui renvoie une liste de comic book dont le titre commence par la valeur donnee en parametre
        /// </summary>
        /// <param name="title">Valeur a rechercher en debut de titre</param>
        /// <returns>Une liste de comics sous forme de <see cref="IEnumerable<ComicBook>"/></returns>
        public async Task<IEnumerable<ComicBook>> GetComicBookAsync(string title)
        {
            var query = new ApiQuery();
            query.AddParameter(new TitleStartsWithParameter(title));

            return await this.client.FetchData(query);
        }
    }
}