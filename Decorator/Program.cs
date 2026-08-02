
using Decorator;
using Decorator.ConcreteDecorator;
using Decorator.PersonajeConcretos;

Personaje personaje = null;
Console.WriteLine("Ingrese que personaje quiere ser");
Console.WriteLine("0- Salir");
Console.WriteLine("1- Mago");
Console.WriteLine("2- Guerrero");

string opcionPersonaje = Console.ReadLine();
if (opcionPersonaje == "0") return;

switch (opcionPersonaje)
{
    case "1":
        personaje = new Mago();
        break;
    case "2":
        personaje = new Guerrero();
        break;
}


while (true)
{
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine($"El poder es: {personaje.Descripcion} {personaje.ObtenerPoder()} ");
    Console.WriteLine("0- Salir");
    Console.WriteLine("1- Agregar escudo (+50 vida)");
    Console.WriteLine("2- Agregar Botas velocidad (+50 velocidad)");
    Console.WriteLine("3- Agregar Pocion mejora ataque (+50 ataque)");
    string opcion = Console.ReadLine();
    if (opcion == "0") return;
    switch (opcion)
    {
        case "1":
            personaje = new Escudo(personaje);
            break;
        case "2":
            personaje = new BotasVelocidad(personaje);
            break;
        case "3":
            personaje = new PocionMejoraAtaque(personaje);
            break;
    }
}