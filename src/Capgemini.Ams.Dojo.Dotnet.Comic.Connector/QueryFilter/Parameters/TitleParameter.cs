namespace Capgemini.Ams.Dojo.Comic.Connector.QueryFilter.Parameters
{
    public class TitleParameter : BaseParameter
    {
        /// <summary>default ctor</summary>
        /// <param name="parameterValue"></param>
        public TitleParameter(string parameterValue)
            : base(parameterValue)
        {
        }

        /// <summary>Specify the webService name of the parameter</summary>
        public override string Name => "title";
    }
}
