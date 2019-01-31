namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Parameters
{
    public class ComicTitleStartsWithParameter : MarvelBaseParameter
    {
        public ComicTitleStartsWithParameter(string parameterValue)
            : base(parameterValue)
        {
        }

        public override string Name => "titleStartsWith";
    }
}