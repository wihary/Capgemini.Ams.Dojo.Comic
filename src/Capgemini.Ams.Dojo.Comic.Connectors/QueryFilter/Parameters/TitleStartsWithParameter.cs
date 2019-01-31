namespace Capgemini.Ams.Dojo.Comic.Connectors.QueryFilter.Parameters
{
    public class TitleStartsWithParameter : BaseParameter
    {
        /// <summary></summary>
        /// <param name="parameterValue"></param>
        public TitleStartsWithParameter(string parameterValue)
            : base(parameterValue)
        {
        }

        /// <summary>Specify the webService name of the parameter</summary>
        public override string Name => "titleStartsWith";
    }
}
