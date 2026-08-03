namespace Memento;

public class CaretakerHistorial
{
    private List<Memento> _mementos = new List<Memento>();
    
    public Memento ObtenerMemento(int indice)
    {
        if (indice < 0)
        {
            
            throw new Exception("El índice no existe en el historial");
        }

        if (indice >= _mementos.Count)
        {
            Console.WriteLine("El indice debe ser menor a " + _mementos.Count);
            throw new Exception("El índice no existe en el historial");
        }

        return _mementos[indice];


    }

    public List<Memento> ObtenerHistorial()
    {
        return _mementos;
    }
    public void AgregarMemento(Memento memento)
    {
        _mementos.Add(memento);
    }
}