namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Parameters
{
    public class ComicTitleParameter : MarvelBaseParameter
    {
        public ComicTitleParameter(string parameterValue) 
            : base(parameterValue)
        {
        }

        public override string Name => "title";
    }
}