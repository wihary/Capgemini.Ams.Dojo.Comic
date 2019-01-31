namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Parameters
{
    public class MarvelAuthorFirstNameParameter : MarvelBaseParameter
    {
        public MarvelAuthorFirstNameParameter(string parameterValue) : base(parameterValue)
        {
        }

        public override string Name => "firstName";
    }
}