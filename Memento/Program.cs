// See https://aka.ms/new-console-template for more information

using Memento;

Cuenta cuentaBancaria = new Cuenta(100);
CaretakerHistorial caretaker = new CaretakerHistorial();
while (true)
{
    Console.WriteLine($"Saldo actual: {cuentaBancaria.GetSaldo()}");
    Console.WriteLine("Ingrese una opcion valida");
    Console.WriteLine("0- Salir");
    Console.WriteLine("1- extraer dinero");
    Console.WriteLine("2- ingresar dinero ");
    Console.WriteLine("3- Mostrar historial ");
    Console.WriteLine("4- Guardar estado actual ");
    Console.WriteLine("5- Restaurar estado");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "0":
            return;
        case "1":
            Console.WriteLine("Ingrese el saldo a extraer");
            decimal saldoExtraer = Convert.ToDecimal(Console.ReadLine());
            cuentaBancaria.ExtraerSaldo(saldoExtraer);
            break;
        case "2":
            Console.WriteLine("Ingrese el saldo a ingresar");
            decimal saldoIngresar = Convert.ToDecimal(Console.ReadLine());
            cuentaBancaria.AgregarSaldo(saldoIngresar);
            break;
        case "3":
            Console.WriteLine("Historial: \n");
            var mementos = caretaker.ObtenerHistorial();
            int contador = 0;
            foreach (var memento in mementos)
            {
                Console.WriteLine($"{contador}:{memento.Saldo}");
                contador++;
            }
            break;
        case "4":
            Console.WriteLine("Guardar estado actual \n");
            var cuentaMemento = cuentaBancaria.GuardarEstado();
            caretaker.AgregarMemento(cuentaMemento);
            break;
        case "5":
            Console.WriteLine("Restaurar estado\n");

            var historial = caretaker.ObtenerHistorial();
            int i = 0;

            foreach (var memento in historial)
            {
                Console.WriteLine($"{i}: {memento.Saldo}");
                i++;
            }

            Console.WriteLine("Ingrese el índice del estado que quiere restaurar");

            try
            {
                int indiceElegido = Convert.ToInt32(Console.ReadLine());
                var mementoElegido = caretaker.ObtenerMemento(indiceElegido);
                cuentaBancaria.RestaurarEstado(mementoElegido);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
    }
}
