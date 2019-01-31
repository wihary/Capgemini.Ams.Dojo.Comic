namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Parameters
{
    public class NameParameter : VineBaseParameter
    {
        /// <summary>default ctor</summary>
        /// <param name="parameterValue"></param>
        public NameParameter(string parameterValue)
            : base(parameterValue)
        {
        }

        /// <summary>Specify the webService name of the parameter</summary>
        public override string Name => "name";
    }
}