using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    //ProductA1
    public class GalaxyS22 : ICelular
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: Galaxy S22\nRAM: 32gb\nCamera: 120mpx";
        }
    }
}