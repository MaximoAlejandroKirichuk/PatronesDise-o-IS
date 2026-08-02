namespace Decorator.ConcreteDecorator;

public class BotasVelocidad : DecoratorBase
{
    public BotasVelocidad(Personaje personaje) : base(personaje)
    {
    }
    public override int Velocidad => _personaje.Velocidad + 50;
    public override string Descripcion => _personaje.Descripcion + "Botas(+50 velocidad)";

}