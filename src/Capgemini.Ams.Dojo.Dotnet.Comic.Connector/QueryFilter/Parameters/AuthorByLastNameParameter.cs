namespace Capgemini.Ams.Dojo.Comic.Connector.QueryFilter.Parameters
{
    public class AuthorByNameParameter: BaseParameter
    {
        public AuthorByNameParameter(string parameterValue) : base(parameterValue)
        {
        }

        public override string Name => "lastName";
    }
}