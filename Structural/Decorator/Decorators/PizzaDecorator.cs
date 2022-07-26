using Decorator.Componentes.Interfaces;

namespace Decorator.Decorators
{
    //Base Decorator
    public abstract class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string BuscarTipoPizza()
        {
           var pizza = _pizza.BuscarTipoPizza();
           return pizza;
        }
    }
}