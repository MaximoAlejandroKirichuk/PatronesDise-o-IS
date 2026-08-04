namespace Iterator;

public class ItemOrdenCompra
{
    public ItemOrdenCompra(string nombre, string producto, bool esUrgente)
    {
        Nombre = nombre;
        Producto = producto;
        EsUrgente = esUrgente;
    }

    public string Nombre { get; set; }
    public string Producto { get; set; }
    public bool EsUrgente { get; set; }

    override public string ToString()
    {
        return Nombre + " " + Producto + " " + EsUrgente;
    }
}