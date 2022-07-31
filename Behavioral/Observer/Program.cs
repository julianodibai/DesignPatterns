using Observer;

var estacaoMetereologica = new EstacaoMetereologica();

var agenciasNoticias1 = new NovasAgenciasNoticias("Agencia de noticia de Porto Seguro");
estacaoMetereologica.Anexar(agenciasNoticias1);

var agenciasNoticias2 = new NovasAgenciasNoticias("Agencia de noticia de Eunapolis");
estacaoMetereologica.Anexar(agenciasNoticias2);

estacaoMetereologica.Temperatura = 31.4f;
estacaoMetereologica.Temperatura = 25f;
estacaoMetereologica.Temperatura = 26.7f;
estacaoMetereologica.Temperatura = 30f;

Console.ReadLine();