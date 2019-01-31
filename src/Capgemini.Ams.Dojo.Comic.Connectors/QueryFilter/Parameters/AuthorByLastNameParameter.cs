namespace Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter.Parameters
{
    public class AuthorByNameParameter: BaseParameter
    {
        public AuthorByNameParameter(string parameterValue) : base(parameterValue)
        {
        }

        public override string Name => "lastName";
    }
}