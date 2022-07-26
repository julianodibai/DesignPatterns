namespace AbstractFactory.Interfaces
{
    //AbstractFactory
    public interface ITelemovel
    {
        ICelular BuscarCelular();
        ITablet BuscarTablet();
    }
}