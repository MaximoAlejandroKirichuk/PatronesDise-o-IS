namespace Iterator.CollectionConcrete;

public class CollectionConcrete : ICollection
{
    public void Guardar(ItemOrdenCompra orden)
    {
        _ordenes.Add(orden);
    }
    private List<ItemOrdenCompra> _ordenes = new List<ItemOrdenCompra>();
    //Oculté la colección interna para que el cliente no dependa de cómo se almacenan los elementos, 
    //y dejé que el recorrido quede encapsulado en los iteradores concretos.
    internal List<ItemOrdenCompra> ObtenerOrdenes()
    {
        return _ordenes;
    }

    public IIterator CrearIteratorFIFO()
    {
        return new IteratorFIFO(this);
    }

    public IIterator CrearIteratorUrgente()
    {
        return new IteratorUrgente(this);
    }
}