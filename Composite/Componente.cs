namespace Composite;

public abstract class Componente
{
    public string Nombre { get;protected set; }
    
    public abstract decimal CalcularPrecio();
}