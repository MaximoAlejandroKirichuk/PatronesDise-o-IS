// See https://aka.ms/new-console-template for more information

using FactoryMethod.FabricasConcretas;
using FactoryMethod.interfaces;

while (true)
{
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("0- Salir");
    Console.WriteLine("1- acuatico");
    Console.WriteLine("2- Terrestre");
    
    string opcion = Console.ReadLine();
    if (opcion == "0") return;

    Console.WriteLine("Ingrese el peso: ");
    decimal peso = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Ingrese el distancia: ");
    decimal distancia = Convert.ToDecimal(Console.ReadLine());
    switch (opcion)
    {
        case "1":
            Fabrica fabrica = new LogisticaAcuatica();
            fabrica.Entregar(peso, distancia);
            break;
        case "2":
            Fabrica fabricaTerrestre = new LogisticaTerrestre();
            fabricaTerrestre.Entregar(peso, distancia);
            break;
        default:
            Console.WriteLine("ingrese un opcion valida");
            break; 
    }
    
}