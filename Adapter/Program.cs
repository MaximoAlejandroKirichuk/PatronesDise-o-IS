// See https://aka.ms/new-console-template for more information

using Adapter;
using Adapter.inrterfaces;


while (true)
{
    Console.WriteLine("Ingrese una opcion");
    Console.WriteLine("1-imprimir con hp");
    Console.WriteLine("2-imprimir con canon vieja");
    Console.WriteLine("0-salir");
    string? opcion = Console.ReadLine();
    if (opcion == "0")return;

    Console.WriteLine("Ingrese texto a imprimir:");
    string? texto = Console.ReadLine();
    
    switch (opcion)
    {
        case "1":
            IImpresora impresora = new ImpresoraHP();
            impresora.Iniciar();
            impresora.Imprimir(texto);
            impresora.Apagar();
            break;
        case "2":
            impresora = new AdaptadorCanonVieja(new CanonViejaImpresora());
            impresora.Iniciar();
            impresora.Imprimir(texto);
            impresora.Apagar();
            break;
        default:
            Console.WriteLine("Ingrese una opcion correcta");
            break;

    }
    
}