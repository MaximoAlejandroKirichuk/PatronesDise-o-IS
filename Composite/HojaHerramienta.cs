namespace Composite;

public class HojaHerramienta : Componente
{
    public decimal Precio { get; set; }
    public HojaHerramienta(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
    public override decimal CalcularPrecio()
    {
        return Precio;
    }
}