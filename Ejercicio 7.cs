// Autor: Romel Rojas
// Ejercicio 7: Interfaces y abstracción
// Descripción: Se define la interfaz IVehiculo con los métodos Encender() y Apagar().
//              Las clases Carro y Motocicleta implementan dicha interfaz,
//              cada una con su propia lógica y mensajes.

// ── Definición de la interfaz ────────────────────────────────────────────────
// Una interfaz es un contrato: cualquier clase que la implemente
// está obligada a definir todos sus métodos.
public interface IVehiculo
{
    void Encender();
    void Apagar();
}

// ── Implementación: Carro ────────────────────────────────────────────────────
public class Carro : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("🚗 El carro enciende: motor V4 en marcha.");
    }

    public void Apagar()
    {
        Console.WriteLine("🚗 El carro se apaga: motor detenido.");
    }
}

// ── Implementación: Motocicleta ──────────────────────────────────────────────
public class Motocicleta : IVehiculo
{
    public void Encender()
    {
        Console.WriteLine("🏍️  La motocicleta enciende: arranque con patada.");
    }

    public void Apagar()
    {
        Console.WriteLine("🏍️  La motocicleta se apaga: llave girada.");
    }
}

// ── Programa principal ───────────────────────────────────────────────────────
public class Ejercicio7
{
    public static void Main()
    {
        Console.WriteLine("── Prueba de vehículos ──\n");

        // Gracias a la interfaz, podemos tratar ambos objetos de forma uniforme
        List<IVehiculo> vehiculos = new List<IVehiculo>
        {
            new Carro(),
            new Motocicleta()
        };

        foreach (IVehiculo vehiculo in vehiculos)
        {
            vehiculo.Encender();
            vehiculo.Apagar();
            Console.WriteLine(); // Separador visual entre vehículos
        }
    }
}
