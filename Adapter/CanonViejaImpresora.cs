namespace Adapter;

public class CanonViejaImpresora
{
    public void ImprimirTexto(string texto)
    {
        Console.WriteLine($"Imprimiendo {texto}");
    }

    public void CortarTexto()
    {
        Console.WriteLine("Cortando texto");
    }

    public void Encender()
    {
        Console.WriteLine("Encendiendo");
    }

    public void Salir()
    {
        Console.WriteLine("Saliendo");
    }
}