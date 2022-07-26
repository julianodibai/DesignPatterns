using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    //ProductA2
    public class GalaxyTabA : ITablet
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Galaxy Tab A S22\nRAM: 128gb\nCamera: 35mgx";
        }
    }
}