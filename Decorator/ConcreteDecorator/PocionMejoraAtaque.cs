namespace Decorator.ConcreteDecorator;

public class PocionMejoraAtaque :DecoratorBase
{
    public PocionMejoraAtaque(Personaje personaje) : base(personaje)
    {
    }

    public override string Descripcion => _personaje.Descripcion + "Pocion(+50 ataque)";
    public override int Ataque => _personaje.Ataque + 50;
}