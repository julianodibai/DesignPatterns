using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    //Client
    public class TelemovelClient
    {
        ICelular celular;
        ITablet tablet;

        public TelemovelClient(ITelemovel telemovelFactory)
        {
            celular = telemovelFactory.BuscarCelular();
            tablet = telemovelFactory.BuscarTablet();
        }

        public string BuscarCelularDetalhes()
        {
            return celular.BuscarDetalhesModelo();
        }
        public string BuscarTabletDetalhes()
        {
            return tablet.BuscarDetalhesModelo();
        }

    }
}