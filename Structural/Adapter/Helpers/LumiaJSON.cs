using Adapter.Helpers.Interfaces;
using Adapter.Models;
using Newtonsoft.Json;

namespace Adapter.Helpers
{
    public class LumiaJSON : ILumiaJSON
    {
        public string GetLumiaMobilesJSONSpecifications()
        {
            List<LumiaMobile> listLumiaMobiles = new List<LumiaMobile>();
            listLumiaMobiles.Add(new LumiaMobile
            {
                IdModelo = "lumia550",
                Altura = "135.0 mm",
                Largura = "65.5 mm",
                Peso = "150.0 g"
            });
            listLumiaMobiles.Add(new LumiaMobile
            {
                IdModelo = "lumia90",
                Altura = "150.0 mm",
                Largura = "110.5 mm",
                Peso = "200.0 g"
            });
            listLumiaMobiles.Add(new LumiaMobile
            {
                IdModelo = "lumiaSS",
                Altura = "145.0 mm",
                Largura = "75.5 mm",
                Peso = "160.0 g"
            });

            dynamic collectionLumiaMobiles = new
            {
                lumiaMobiles = listLumiaMobiles
            };

            return JsonConvert.SerializeObject(collectionLumiaMobiles);
        }
    }
}