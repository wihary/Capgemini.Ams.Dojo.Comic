using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;

namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Parameters
{
    public static class MarvelParamExtension
    {
        public static MarvelQuery ConvertToProviderParameter(this ApiQuery apiQuery)
        {
            var queryResult = new MarvelQuery();

            foreach (var parameter in apiQuery.Parameters)
            {
                switch (parameter.Name)
                {
                    case "title":
                        queryResult.AddParameter(new ComicTitleParameter(parameter.value));
                        break;
                    case "titleStartsWith":
                        queryResult.AddParameter(new ComicTitleStartsWithParameter(parameter.value));
                        break;
                    case "SerieTitle":
                        queryResult.AddParameter(new ComicTitleParameter(parameter.value));
                        break;
                    case "lastName":
                        queryResult.AddParameter(new MarvelAuthorLastNameParameter(parameter.value));
                        break;
                    case "firstName":
                        queryResult.AddParameter(new MarvelAuthorFirstNameParameter(parameter.value));
                        break;
                    default:
                        break;
                }

            }
            return queryResult;
        }
    }
}