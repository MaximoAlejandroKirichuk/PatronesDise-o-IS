namespace Singleton;

public sealed class Logger
{
    private static Logger InstanciaUnica;
    private static readonly object _lock = new object();
    private int cantidadMensaje = 0;
    private Logger(){}

    public static Logger ObtenerInstancia()
    {
        if (InstanciaUnica == null)
        {
            lock (_lock)
            {
                if (InstanciaUnica == null)
                {
                    InstanciaUnica = new Logger();
                }
            }
        }
        return InstanciaUnica;
    }

    public int GetCantidadMensaje()
    {
        return cantidadMensaje;
    }
    public void Alerta(string mensaje)
    {
        cantidadMensaje++;
        Console.WriteLine($"Alerta: {mensaje}");
    }
    public void Error(string mensaje)
    {
        Console.WriteLine($"Error: {mensaje}");
        cantidadMensaje++;
    }
}