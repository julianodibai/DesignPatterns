using System.Xml;

namespace Adapter.Helpers.Interfaces
{
    public interface ILumiaXMLTarget
    {
        XmlDocument GetLumiaMobilesXMLSpecifications();
    }
}