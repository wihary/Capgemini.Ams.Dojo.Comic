namespace Capgemini.Ams.Dojo.Comic.Connector.QueryFilter.Parameters
{
    public class AuthorByFirstNameParameter : BaseParameter
    {
        public AuthorByFirstNameParameter(string parameterValue) : base(parameterValue)
        {
        }

        public override string Name => "firstName";
    }
}