namespace Iterator.CollectionConcrete;

public class IteratorUrgente : IIterator
{
    private List<ItemOrdenCompra> _collectionIteratorEstado;
    private int contador = 0;
    public IteratorUrgente(CollectionConcrete collection)
    {
        _collectionIteratorEstado = new List<ItemOrdenCompra>();

        foreach (ItemOrdenCompra orden in collection.ObtenerOrdenes())
        {
            if (orden.EsUrgente)
            {
                _collectionIteratorEstado.Add(orden);
            }
        }

        foreach (ItemOrdenCompra orden in collection.ObtenerOrdenes())
        {
            if (!orden.EsUrgente)
            {
                _collectionIteratorEstado.Add(orden);
            }
        }
    }
    public bool HasNext()
    {
       return _collectionIteratorEstado.Count > contador;
    }

    public ItemOrdenCompra Next()
    {
        return _collectionIteratorEstado[contador++];
    }
}