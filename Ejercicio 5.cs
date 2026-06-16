// Autor: Romel Rojas
// Ejercicio 5: Polimorfismo
// Descripción: Se crea una lista List<Animal> con objetos Perro y Gato.
//              Al recorrer la lista, cada objeto llama su propia versión
//              de HacerSonido() — eso es polimorfismo en acción.

// ── Clase base ───────────────────────────────────────────────────────────────
public class Animal
{
    // Nombre del animal para identificarlo en la salida
    public string Nombre { get; set; }

    // Método virtual que será sobreescrito por cada clase hija
    public virtual void HacerSonido()
    {
        Console.WriteLine($"{Nombre} emite un sonido.");
    }
}

// ── Clases hijas ─────────────────────────────────────────────────────────────

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau, guau!");
    }
}

public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine($"{Nombre} dice: ¡Miau!");
    }
}

// ── Programa principal ───────────────────────────────────────────────────────
class Ejercicio5
{
    static void Main(string[] args)
    {
        Console.WriteLine("── Polimorfismo: recorriendo lista de animales ──\n");

        // Lista de tipo base Animal que almacena objetos de tipos distintos
        List<Animal> animales = new List<Animal>
        {
            new Perro { Nombre = "Rex"    },
            new Gato  { Nombre = "Mishi"  },
            new Perro { Nombre = "Toby"   },
            new Gato  { Nombre = "Pelusa" }
        };

        // El foreach llama HacerSonido() y C# decide en tiempo de ejecución
        // qué versión usar según el tipo real del objeto (ligadura dinámica)
        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
        }
    }
}
