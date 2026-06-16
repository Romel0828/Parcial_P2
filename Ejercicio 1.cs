// Autor: Romel Rojas
// Ejercicio 1: Sintaxis básica y variables
// Descripción: Programa que muestra un mensaje de bienvenida y declara
//              variables de distintos tipos para imprimirlas en pantalla.

class Ejercicio1
{
    static void Main(string[] args)
    {
        // Mensaje de bienvenida con el nombre del grupo
        Console.WriteLine("========================================");
        Console.WriteLine("   Bienvenidos al grupo: Programación II");
        Console.WriteLine("========================================\n");

        // Declaración de variables de distintos tipos
        string nombreEstudiante = "Romel Rojas";   // Tipo string: nombre del estudiante
        int anioIngreso        = 2025;              // Tipo int: año de ingreso a la carrera
        double promedioGeneral = 9.2;              // Tipo double: promedio académico
        bool estaActivo        = true;             // Tipo bool: si el estudiante está activo

        // Impresión de cada variable con su descripción
        Console.WriteLine("Nombre del estudiante : " + nombreEstudiante);
        Console.WriteLine("Año de ingreso        : " + anioIngreso);
        Console.WriteLine("Promedio general      : " + promedioGeneral);
        Console.WriteLine("Estudiante activo     : " + estaActivo);
    }
}
