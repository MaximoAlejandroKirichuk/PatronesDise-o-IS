namespace Decorator.PersonajeConcretos;

public class Guerrero : Personaje
{
    public Guerrero()
    {
        Velocidad = 50;
        Ataque = 100;
        Vida = 100;
        Descripcion = "Guerrero: ";
    }
    public override string Descripcion { get; }
    public override int Velocidad { get; }
    public override int Ataque { get; }
    public override int Vida { get; }
}