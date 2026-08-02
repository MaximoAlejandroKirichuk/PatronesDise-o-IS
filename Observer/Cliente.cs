namespace Observer;

public class Cliente : IObservador
{
    public Cliente(string nombre)
    {
        Nombre = nombre;
    }

    public string  Nombre { get; set; }
    public void Actualizar(string texto)
    {
        Console.WriteLine($"{Nombre} fue notificado: {texto}");
    }
}