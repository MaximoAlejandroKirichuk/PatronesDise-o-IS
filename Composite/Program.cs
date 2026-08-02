// See https://aka.ms/new-console-template for more information

using Composite;
CompositeKit compra = new CompositeKit("Compra");

HojaHerramienta martillo = new HojaHerramienta("Martillo", 100);
HojaHerramienta clavo = new HojaHerramienta("Clavo", 100);
HojaHerramienta mazo = new HojaHerramienta("Mazo", 100);

CompositeKit kitHerramientaManual = new CompositeKit("Kit Manual");
kitHerramientaManual.Agregar(martillo);
kitHerramientaManual.Agregar(clavo);
kitHerramientaManual.Agregar(mazo);

HojaHerramienta destornilladorElectrico = new HojaHerramienta("Destornillador Eléctrico", 300);
HojaHerramienta linternaElectrica = new HojaHerramienta("Linterna Eléctrica", 300);

CompositeKit kitHerramientaElectrica = new CompositeKit("Kit Eléctrico");
kitHerramientaElectrica.Agregar(destornilladorElectrico);
kitHerramientaElectrica.Agregar(linternaElectrica);

while (true)
{
    Console.WriteLine("Ingrese una opción para agregar a la venta");
    Console.WriteLine($"Precio actual de la venta: {compra.CalcularPrecio()}");
    Console.WriteLine($"1 - {martillo.Nombre} ({martillo.CalcularPrecio()})");
    Console.WriteLine($"2 - {clavo.Nombre} ({clavo.CalcularPrecio()})");
    Console.WriteLine($"3 - {mazo.Nombre} ({mazo.CalcularPrecio()})");
    Console.WriteLine($"4 - {kitHerramientaManual.Nombre} ({kitHerramientaManual.CalcularPrecio()})");
    Console.WriteLine($"5 - {destornilladorElectrico.Nombre} ({destornilladorElectrico.CalcularPrecio()})");
    Console.WriteLine($"6 - {linternaElectrica.Nombre} ({linternaElectrica.CalcularPrecio()})");
    Console.WriteLine($"7 - {kitHerramientaElectrica.Nombre} ({kitHerramientaElectrica.CalcularPrecio()})");
    Console.WriteLine("0 - Salir");

    string? opcion = Console.ReadLine();

    if (opcion == "0")
    {
        Console.WriteLine($"Precio final de la venta: {compra.CalcularPrecio()}");
        return;
    }

    switch (opcion)
    {
        case "1":
            compra.Agregar(martillo);
            break;
        case "2":
            compra.Agregar(clavo);
            break;
        case "3":
            compra.Agregar(mazo);
            break;
        case "4":
            compra.Agregar(kitHerramientaManual);
            break;
        case "5":
            compra.Agregar(destornilladorElectrico);
            break;
        case "6":
            compra.Agregar(linternaElectrica);
            break;
        case "7":
            compra.Agregar(kitHerramientaElectrica);
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}