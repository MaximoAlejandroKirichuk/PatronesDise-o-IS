namespace Decorator;

public abstract class Personaje
{
    public abstract string Descripcion { get;  }
    public abstract int Velocidad { get; }
    public abstract int Ataque { get; }
    public abstract int Vida { get; }
    public virtual int ObtenerPoder()
    {
        return Velocidad + Ataque + Vida; 
    }


}