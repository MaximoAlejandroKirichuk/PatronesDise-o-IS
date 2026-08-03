namespace Memento;

public class Cuenta
{
    private decimal Saldo { get; set; }
    
    public Cuenta(decimal saldo)
    {
        Saldo = saldo;
    }

    public void AgregarSaldo(decimal saldo)
    {
        if (saldo <= 0)
        {
            Console.WriteLine("El saldo a agregar no puede ser menor o igual a 0");
            return;
        }
        Saldo += saldo;
    }

    public void ExtraerSaldo(decimal saldo)
    {
        if (saldo <= 0)
        {
            Console.WriteLine("El saldo a extraer no puede ser menor o igual a 0");
            return;
        }
        if (Saldo < saldo)
        {
            Console.WriteLine("No puede existir saldo insuficiente");
            return;
        }
        Saldo -= saldo;
    }

    public decimal GetSaldo()
    {
        return Saldo;
    }
    public Memento GuardarEstado()
    {
        return new Memento(this.Saldo);
    }

    public void RestaurarEstado(Memento memento)
    {
        Saldo = memento.Saldo;
    }
}
