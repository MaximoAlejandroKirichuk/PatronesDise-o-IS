namespace FactoryMethod.interfaces;

public abstract class Fabrica
{
    protected abstract ITransporte ElegirTransporte(decimal peso, decimal distancia);

    public void Entregar(decimal peso, decimal distancia)
    {
        var transporte = ElegirTransporte(peso, distancia);
        transporte.Entregar();
    }
}