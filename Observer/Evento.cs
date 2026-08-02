using System.Runtime.InteropServices.JavaScript;

namespace Observer;

public class Evento : ISujeto
{
    public Evento(string nombre, string lugar, decimal precio)
    {
        Nombre = nombre;
        Lugar = lugar;
        PrecioEntrada = precio;
    }
    private List<IObservador> observadores = new List<IObservador>();
    public string Nombre { get; set; }
    public string Lugar { get; set; }
    public decimal PrecioEntrada { get; set; }


    public void Suscribir(IObservador observador)
    {
        if (!observadores.Contains(observador))
            observadores.Add(observador);

    }

    public void Desuscribir(IObservador observador)
    {
        observadores.Remove(observador);
    }

    public void Notificar(string texto)
    {
        foreach (var observador in observadores)
        {
            observador.Actualizar(texto);
        }
    }

    public void CambiarPrecioEntrada(decimal nuevoPrecio)
    {
        if (PrecioEntrada == nuevoPrecio) return;
        PrecioEntrada = nuevoPrecio;
        Notificar($"El precio ha cambiado: {nuevoPrecio}"); 
    }
}