namespace Decorator;

public abstract class DecoratorBase : Personaje
{
    protected Personaje _personaje;

    public DecoratorBase(Personaje personaje)
    {
        _personaje = personaje;
    }
    //delego a entidad personaje.
    public override int Velocidad => _personaje.Velocidad;
    public override int Vida => _personaje.Vida;
    public override int Ataque => _personaje.Ataque;
    public override string Descripcion => _personaje.Descripcion;
}