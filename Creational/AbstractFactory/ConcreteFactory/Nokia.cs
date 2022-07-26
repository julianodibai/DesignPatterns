using AbstractFactory.Interfaces;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteFactory
{
    //ConcreteFactory
    public class Nokia : ITelemovel
    {
        public ICelular BuscarCelular()
        {
            return new NokiaG21();
        }

        public ITablet BuscarTablet()
        {
            return new NokiaTabT20();
        }
    }
}