using Decorator.Componentes.Interfaces;

namespace Decorator.Decorators
{
    //concrete decorator
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += " com extra de queijo";

            return pizza;
        }
    }
}