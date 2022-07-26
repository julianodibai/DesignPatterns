using AbstractFactory;
using AbstractFactory.ConcreteFactory;
using AbstractFactory.Interfaces;
using static System.Console;

ITelemovel samsungTelemovel = new Samsung();
ITelemovel nokiaTelemovel = new Nokia();

TelemovelClient samsungClient = new TelemovelClient(samsungTelemovel);
TelemovelClient nokiaClient = new TelemovelClient(nokiaTelemovel);

WriteLine("\n###### SAMSUNG ######");
WriteLine(samsungClient.BuscarCelularDetalhes()+"\n");
WriteLine(samsungClient.BuscarTabletDetalhes());

WriteLine("\n###### NOKIA ######");
WriteLine(nokiaClient.BuscarCelularDetalhes()+"\n");
WriteLine(nokiaClient.BuscarTabletDetalhes());

ReadKey();