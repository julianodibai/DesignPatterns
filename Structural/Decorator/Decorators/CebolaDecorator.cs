using Decorator.Componentes.Interfaces;

namespace Decorator.Decorators
{
    //concrete decorator
    public class CebolaDecorator : PizzaDecorator
    {
        public CebolaDecorator(IPizza pizza) : base(pizza)
        {
        }
        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += " com extra de Cebola";

            return pizza;
        }

    }
}