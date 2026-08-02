using FactoryMethod.interfaces;

namespace FactoryMethod.TransportesConcretos.Terrestre;

public class Camion : ITransporte
{
    public void Entregar()
    {
        Console.WriteLine("Entregando en camion");
    }
}