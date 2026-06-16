// Autor: Romel Rojas
// Ejercicio 4: Herencia
// Descripción: Clase base Animal con método HacerSonido().
//              Las clases Perro y Gato heredan de Animal y sobreescriben el método.

// ── Clase base ───────────────────────────────────────────────────────────────
public class Animal
{
    // Método virtual: permite que las clases hijas lo sobreescriban
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal emite un sonido genérico.");
    }
}

// ── Clases hijas ─────────────────────────────────────────────────────────────

// Perro hereda de Animal y sobreescribe HacerSonido con su propio sonido
public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Perro dice: ¡Guau, guau!");
    }
}

// Gato hereda de Animal y sobreescribe HacerSonido con su propio sonido
public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("Gato dice: ¡Miau!");
    }
}

// ── Programa principal ───────────────────────────────────────────────────────
public class Ejercicio4
{
    public static void Main()
    {
        Console.WriteLine("── Sonidos de animales ──\n");

        // Creación de un objeto de cada tipo
        Animal animalBase = new Animal();
        Perro  miPerro    = new Perro();
        Gato   miGato     = new Gato();

        // Llamada al método correspondiente según el tipo real del objeto
        animalBase.HacerSonido();
        miPerro.HacerSonido();
        miGato.HacerSonido();
    }
}
