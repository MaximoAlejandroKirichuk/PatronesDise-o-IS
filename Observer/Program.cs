// See https://aka.ms/new-console-template for more information

using Observer;

var cliente1 = new Cliente("Maxi");
var cliente2 = new Cliente("Fer");

var evento = new Evento("reunion c#", "capital", 2000.99m);

while (true)
{
    Console.WriteLine("Ingrese una opcion: ");
    Console.WriteLine("1- suscribir ambos");
    Console.WriteLine("2- desuscribir ambos");
    Console.WriteLine("3- cambiar precio entrada al evento");
    Console.WriteLine("0. Salir");
    
    var opcion = Console.ReadLine();
    switch (opcion)
    {
        case "0": 
            return;
        case "1":
            evento.Suscribir(cliente1);
            evento.Suscribir(cliente2);
            break;
        case "2":
            evento.Desuscribir(cliente1);
            evento.Desuscribir(cliente2);
            break;
        case "3":
            Console.WriteLine("Ingrese precio entrada: ");
            decimal precio = Convert.ToDecimal(Console.ReadLine());
            evento.CambiarPrecioEntrada(precio);
            break;
        case "4":
            Console.WriteLine("Ingrese un valor valido");
            continue;
    }
}
