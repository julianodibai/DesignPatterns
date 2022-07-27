using Decorator.Componentes.Interfaces;

namespace Decorator.Componentes
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            string tipoPizza = "Pizza normal";
            return tipoPizza;
        }
    }
}