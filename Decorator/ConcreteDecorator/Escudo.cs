namespace Decorator.ConcreteDecorator;

public class Escudo : DecoratorBase
{
    public Escudo(Personaje personaje) : base(personaje)
    {
    }

    public override int Vida => _personaje.Vida + 50;
    public override string Descripcion => _personaje.Descripcion + "Escudo(+50 vida)";
}