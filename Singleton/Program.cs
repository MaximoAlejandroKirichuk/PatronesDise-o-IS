using Singleton;

Logger loggerSingleton = Logger.ObtenerInstancia();
Logger verificar = Logger.ObtenerInstancia();
while (true)
{
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("0- Salir ");
    Console.WriteLine("1- escribir mensaje error: ");
    Console.WriteLine("2- escribir mensaje alerta: ");
    Console.WriteLine("3- Obtener cantidad mensaje: ");
    Console.WriteLine("4- Verificar");
    string opcion = Console.ReadLine();
    if (opcion == "0") return;
    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese mensaje: ");
            string mensaje = Console.ReadLine();
            loggerSingleton.Error(mensaje);
            break;
        case "2":
            Console.WriteLine("Ingrese mensaje: ");
            string mensajeAlerta = Console.ReadLine();
            loggerSingleton.Alerta(mensajeAlerta);
            break;
        case "3":
            Console.WriteLine($"Cantidad mensaje:{loggerSingleton.GetCantidadMensaje()} ");
            break;
        case "4":
            if (loggerSingleton == verificar)
            {
                Console.WriteLine("Son iguales");
            }
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
}