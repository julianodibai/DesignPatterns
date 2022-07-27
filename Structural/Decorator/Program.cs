using Decorator.Componentes;
using Decorator.Componentes.Interfaces;
using Decorator.Decorators;
using static System.Console;

IPizza pizza = new Pizza();
IPizza pizzaQueijo = new QueijoDecorator(pizza);
IPizza pizzaBacon = new BaconDecorator(pizza);
IPizza pizzaCebola = new CebolaDecorator(pizzaQueijo);

WriteLine(pizza.BuscarTipoPizza());
WriteLine(pizzaQueijo.BuscarTipoPizza());
WriteLine(pizzaBacon.BuscarTipoPizza());
WriteLine(pizzaCebola.BuscarTipoPizza());
