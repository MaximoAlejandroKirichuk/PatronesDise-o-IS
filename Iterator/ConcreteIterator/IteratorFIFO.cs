namespace Iterator.CollectionConcrete;

public class IteratorFIFO : IIterator
{
    private List<ItemOrdenCompra> _collectionIteratorEstado;
    private int _contador = 0;
    public IteratorFIFO(CollectionConcrete collection)
    {
        _collectionIteratorEstado = collection.ObtenerOrdenes();
    }
    
    public bool HasNext()
    {
        return  _collectionIteratorEstado.Count> _contador;
    }

    public ItemOrdenCompra Next()
    {
        return _collectionIteratorEstado[_contador++];
    }
}