// Autor: Romel Rojas
// Ejercicio 3: Clases y objetos
// Descripción: Se define la clase Persona con propiedades Nombre y Edad,
//              y un método Presentarse(). Se crean tres objetos en el Main.

// Definición de la clase Persona
class Persona
{
    // Propiedades públicas accesibles desde fuera de la clase
    public string Nombre { get; set; }
    public int    Edad   { get; set; }

    // Método que imprime una presentación del objeto
    public void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}

class Ejercicio3
{
    static void Main(string[] args)
    {
        Console.WriteLine("── Presentaciones del grupo ──\n");

        // Creación de tres objetos Persona usando inicializadores de objeto
        Persona integrante1 = new Persona { Nombre = "Romel Rojas",    Edad = 20 };
        Persona integrante2 = new Persona { Nombre = "Carlos Méndez",  Edad = 21 };
        Persona integrante3 = new Persona { Nombre = "Laura Castillo", Edad = 22 };

        // Llamada al método Presentarse() de cada objeto
        integrante1.Presentarse();
        integrante2.Presentarse();
        integrante3.Presentarse();
    }
}
