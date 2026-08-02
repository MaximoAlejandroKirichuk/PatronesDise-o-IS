using FactoryMethod.interfaces;
using FactoryMethod.TransportesConcretos.Terrestre;

namespace FactoryMethod.FabricasConcretas;

public class LogisticaTerrestre : Fabrica
{
    private const decimal DistanciaMaxMotoKm = 200;
    private const decimal PesoMaxMotoKg = 200;
    protected override ITransporte ElegirTransporte(decimal peso, decimal distancia)
    {
        if (peso < PesoMaxMotoKg && distancia < DistanciaMaxMotoKm)
        {
            return new Moto();
        }
        return new Camion();
    }
}