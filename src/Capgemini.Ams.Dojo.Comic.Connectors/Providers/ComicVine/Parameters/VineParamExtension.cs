using Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter;

namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Parameters
{
    public static class VineParamExtension
    {
        public static ComicVineQuery ConvertToProviderParameter(this ApiQuery apiQuery)
        {
            var queryResult = new ComicVineQuery();

            foreach (var parameter in apiQuery.Parameters)
            {
                switch (parameter.Name)
                {
                    case "title":
                    case "titleStartsWith":
                        queryResult.AddParameter(new NameParameter(parameter.value));
                        break;
                    default:
                        break;
                }

            }
            return queryResult;
        }
    }
}