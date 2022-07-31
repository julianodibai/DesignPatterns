using System.Xml;
using Adapter.Helpers.Interfaces;
using Newtonsoft.Json;

namespace Adapter.Helpers
{
    public class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public XmlDocument GetLumiaMobilesXMLSpecifications()
        {
            LumiaJSON lumiaJsonAdaptee = new LumiaJSON();
            
            string jsonLumia = lumiaJsonAdaptee.GetLumiaMobilesJSONSpecifications();

            var doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMobiles", true);
            
            return doc;
        }
    }
}