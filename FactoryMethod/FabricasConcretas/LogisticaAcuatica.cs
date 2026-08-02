using FactoryMethod.interfaces;
using FactoryMethod.TransportesConcretos.acuatico;

namespace FactoryMethod.FabricasConcretas;

public class LogisticaAcuatica : Fabrica
{
    private const decimal PesoMaxYateKg = 500;

    protected override ITransporte ElegirTransporte(decimal peso, decimal distancia)
    {
        if (peso < PesoMaxYateKg)
        {
            return new Yate();
        }

        return new Buque();
    }
}