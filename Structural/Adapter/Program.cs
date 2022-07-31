using Adapter.Helpers;
using Adapter.Helpers.Interfaces;

ILumiaXMLTarget lumiaXMLTarget = new LumiaXMLAdapter();

var xmlLumia = lumiaXMLTarget.GetLumiaMobilesXMLSpecifications();

Console.WriteLine(xmlLumia.InnerText);
