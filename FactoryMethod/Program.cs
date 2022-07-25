using Factory_Method.ConcreteCreator;
using Factory_Method.Creator;
using Factory_Method.Product;
using static System.Console;

CartaoFactory cartaoFactory =null;

Write("Digite o tipo de cartão que gostaria de obter: ");
string tipoCartao = ReadLine();

switch (tipoCartao.ToLower())
{
    case "black":
        cartaoFactory = new BlackFactory(50000, 0);
        break;

    case "titanium":
        cartaoFactory = new TitaniumFactory(120000, 500);
        break;
    case "platinum":
        cartaoFactory = new PlatinumFactory(270000, 105);
        break;  

    default:
        WriteLine("Tipo de cartão informado não existe ou está errado");
        WriteLine("Exemplos: Platinum. Black e Titanium");
        break;
}

CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();

WriteLine("\nOs detalhes do seu cartão estão a baixo \n");
WriteLine($"Tipo do cartão: {cartaoCredito.TipoCartao}\nCrédito limite: {cartaoCredito.LimiteCredito}\nCobrança anual: {cartaoCredito.CobrancaAnual}");
ReadKey();