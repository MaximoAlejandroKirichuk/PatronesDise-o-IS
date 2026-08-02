using Adapter.inrterfaces;

namespace Adapter;

public class AdaptadorCanonVieja : IImpresora
{
    private readonly CanonViejaImpresora Impresora;

    public AdaptadorCanonVieja(CanonViejaImpresora impresora )
    {
        Impresora = impresora;   
    }
    public void Iniciar()
    {
        Impresora.Encender();
    }

    public void Imprimir(string texto)
    {
        Impresora.CortarTexto();
        Impresora.ImprimirTexto(texto);
    }

    public void Apagar()
    {
        Impresora.Salir();
    }
}