namespace Decorator.PersonajeConcretos;

public class Mago : Personaje
{
    public Mago()
    {
        Vida = 100;
        Velocidad = 100;
        Ataque = 50;
        Descripcion = "Mago: ";
    }
    public override string Descripcion { get; }
    public override int Velocidad { get; }
    public override int Ataque { get; }
    public override int Vida { get; }
}