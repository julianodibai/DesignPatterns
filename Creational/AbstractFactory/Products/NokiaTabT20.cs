using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    //ProductB1
    public class NokiaTabT20 : ITablet
    {
        public string BuscarDetalhesModelo()
        {
           return "Model: Nokia Tab T20 S22\nRAM: 110gb\nCamera: 22mgpx";
        }
    }
}