using AbstractFactory.Interfaces;
using AbstractFactory.Products;

namespace AbstractFactory.ConcreteFactory
{
    //ConcreteFactory
    public class Samsung : ITelemovel
    {  
        public ICelular BuscarCelular()
        {
            return new GalaxyS22();
        }

        public ITablet BuscarTablet()
        {
            return new GalaxyTabA();
        }
    }
}