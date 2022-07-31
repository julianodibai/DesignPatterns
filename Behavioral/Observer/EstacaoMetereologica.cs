using Observer.Interfaces;

namespace Observer
{
    public class EstacaoMetereologica : ISubject
    {
        private List<IObserver> observers;
        private float _temperatura;
        public float Temperatura 
        {
            get{ return _temperatura; } 
            set
            {
                _temperatura = value; 
                Notificar(); 
            } 
        }

        public EstacaoMetereologica()
        {
            observers = new List<IObserver>();
        }

        
        public void Anexar(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notificar()
        {
            observers.ForEach(o => {
                o.Atualizar(this);
            });
        }
    }
}