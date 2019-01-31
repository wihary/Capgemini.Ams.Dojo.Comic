namespace Capgemini.Ams.Dojo.Comic.Connectors.Providers.ComicVine.Parameters
{
    public class ComicByVolumeParameter: VineBaseParameter
    {
        /// <summary>default ctor</summary>
        /// <param name="parameterValue"></param>
        public ComicByVolumeParameter(string parameterValue)
            : base(parameterValue)
        {
        }

        /// <summary>Specify the webService name of the parameter</summary>
        public override string Name => "volume";
    }
}