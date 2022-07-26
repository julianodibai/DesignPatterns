using AbstractFactory.Interfaces;

namespace AbstractFactory.Products
{
    //ProductB1
    public class NokiaG21 : ICelular
    {
        public string BuscarDetalhesModelo()
        {
            return "Model: NokiaG21 S22\nRAM: 32gb\nCamera: 110mpx";
        }
    }
}