// See https://aka.ms/new-console-template for more information

using Iterator;
using Iterator.CollectionConcrete;

CollectionConcrete collectionOrdenes = new CollectionConcrete();

while (true)
{
    Console.WriteLine("Ingrese un valor");
    Console.WriteLine("0-Salir");
    Console.WriteLine("1- Agregar una nueva orden de compra");
    Console.WriteLine("2- Ver lista por orden de llegada");
    Console.WriteLine("3- Ver lista por urgencia ");
 
    string opcion = Console.ReadLine();
    if (opcion == "0") return;
    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese el nombre del cliente de la compra");
            string nombreCliente = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del producto de la orden");
            string productoNombre = Console.ReadLine();
            Console.WriteLine("Ingrese si es urgente la compra: (s/n)");
            bool esUrgente = Console.ReadLine().ToLower() == "s";
            var orden = new ItemOrdenCompra(nombreCliente, productoNombre,esUrgente);
            collectionOrdenes.Guardar(orden);
            break;
        case "2":
            var fifo = collectionOrdenes.CrearIteratorFIFO();
            while (fifo.HasNext() == true)
            {
                Console.WriteLine(fifo.Next().ToString());
            }
            break;
        case "3":
            var urgente = collectionOrdenes.CrearIteratorUrgente();
            while (urgente.HasNext() == true)
            {
                Console.WriteLine(urgente.Next().ToString());
            }
            break;
        default:
            Console.WriteLine("Ingrese un valor valido");
            break;
    }
}