using FactoryMethod.interfaces;

namespace FactoryMethod.TransportesConcretos.Terrestre;

public class Moto : ITransporte
{
    public void Entregar()
    {
        Console.WriteLine("Entregando en MOTO");
    }
}