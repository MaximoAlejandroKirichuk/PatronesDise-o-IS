namespace Composite;

public class CompositeKit : Componente
{
    private List<Componente> componentes = new List<Componente>();

    public CompositeKit(string nombre)
    {
        Nombre = nombre;
    }
    public override decimal CalcularPrecio()
    {
        decimal total = 0;
        foreach (var componente in componentes)
        {
            total += componente.CalcularPrecio();
        }
        return total;
    }

    public void Agregar(Componente componente)
    {
        componentes.Add(componente);
    }

    public void Eliminar(Componente componente)
    {
        componentes.Remove(componente);
    }
}