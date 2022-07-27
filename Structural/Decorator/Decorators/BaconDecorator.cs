using Decorator.Componentes.Interfaces;

namespace Decorator.Decorators
{
    //concrete decorator
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += " com extra de Bacon";

            return pizza;
        }
    }
}