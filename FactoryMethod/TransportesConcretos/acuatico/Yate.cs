using FactoryMethod.interfaces;

namespace FactoryMethod.TransportesConcretos.acuatico;

public class Yate : ITransporte
{
    public void Entregar()
    {
        Console.WriteLine("Entregando en yate");
    }
}