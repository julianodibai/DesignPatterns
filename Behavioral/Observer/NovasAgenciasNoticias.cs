using Observer.Interfaces;

namespace Observer
{
    public class NovasAgenciasNoticias : IObserver
    {
        public string NomeAgencia { get; set; }

        public NovasAgenciasNoticias(string nomeAgencia)
        {
            NomeAgencia = nomeAgencia;
        }

        public void Atualizar(ISubject subject)
        {
            if (subject is EstacaoMetereologica estacaoMetereologica)
            {
                Console.WriteLine(string.Format($"{NomeAgencia} reportando a temperatura {estacaoMetereologica.Temperatura} graus celsius"));
                Console.WriteLine();
            };
        }
    }
}