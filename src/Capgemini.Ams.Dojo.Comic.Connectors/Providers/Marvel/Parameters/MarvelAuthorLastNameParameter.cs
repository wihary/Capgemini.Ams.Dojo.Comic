namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.Marvel.Parameters
{
    public class MarvelAuthorLastNameParameter : MarvelBaseParameter
    {
        public MarvelAuthorLastNameParameter(string parameterValue) : base(parameterValue)
        {
        }

        public override string Name => "lastName";
    }
}