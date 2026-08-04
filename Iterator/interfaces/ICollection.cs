namespace Iterator;

public interface ICollection
{
    void Guardar(ItemOrdenCompra orden);
    IIterator CrearIteratorFIFO();
    IIterator CrearIteratorUrgente();
}