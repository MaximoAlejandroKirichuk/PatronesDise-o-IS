using Adapter.inrterfaces;

namespace Adapter;

public class ImpresoraHP : IImpresora
{
    public void Iniciar()
    {
        Console.WriteLine("ImpresoraHP Iniciar");
    }

    public void Imprimir(string texto)
    {
        Console.WriteLine(texto);
    }

    public void Apagar()
    {
        Console.WriteLine("ImpresoraHP Apagar");
    }
}