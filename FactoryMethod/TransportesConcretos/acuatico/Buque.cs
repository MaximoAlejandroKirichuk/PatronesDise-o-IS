using FactoryMethod.interfaces;

namespace FactoryMethod.TransportesConcretos.acuatico;

public class Buque : ITransporte
{
    public void Entregar()
    {
        Console.WriteLine("Entregando en buque");
    }
}