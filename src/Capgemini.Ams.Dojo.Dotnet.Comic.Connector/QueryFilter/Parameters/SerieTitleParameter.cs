namespace Capgemini.Ams.Dojo.Comic.Connector.QueryFilter.Parameters
{
    public class SerieTitleParameter : BaseParameter
    {
        public SerieTitleParameter(string parameterValue) 
            : base(parameterValue)
        {
        }

        public override string Name => "SerieTitle";
    }
}