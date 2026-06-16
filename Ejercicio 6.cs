// Autor: Romel Rojas
// Ejercicio 6: Encapsulamiento
// Descripción: Clase CuentaBancaria con atributo privado saldo.
//              Solo se puede acceder al saldo a través de métodos públicos,
//              lo que protege el dato interno (principio de encapsulamiento).

public class CuentaBancaria
{
    // Atributo privado: no es accesible directamente desde fuera de la clase
    private decimal saldo;

    // Constructor: inicializa la cuenta con saldo cero
    public CuentaBancaria()
    {
        saldo = 0;
    }

    // Método público para depositar dinero
    // Solo acepta montos positivos para evitar depósitos inválidos
    public void Depositar(decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto a depositar debe ser mayor que cero.");
            return;
        }

        saldo += monto;
        Console.WriteLine($"Depósito de {monto:C} realizado con éxito.");
    }

    // Método público para consultar el saldo actual
    public void ObtenerSaldo()
    {
        Console.WriteLine($"Saldo actual de la cuenta: {saldo:C}");
    }
}

public class Ejercicio6
{
    public static void Main()
    {
        Console.WriteLine("── Sistema de Cuenta Bancaria ──\n");

        // Creación del objeto; el saldo privado es inaccesible directamente
        CuentaBancaria cuenta = new CuentaBancaria();

        // Se interactúa con el saldo solo a través de los métodos
        cuenta.Depositar(5000);
        cuenta.Depositar(1500.50m);
        cuenta.Depositar(-200);     // Intento de depósito inválido
        cuenta.ObtenerSaldo();
    }
}
