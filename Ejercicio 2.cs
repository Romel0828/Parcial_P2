// Autor: Romel Rojas
// Ejercicio 2: Estructuras de control
// Descripción: Programa que determina si un número es par o impar,
//              y luego imprime los números del 1 al 10 con un bucle for.

class Ejercicio2
{
    static void Main(string[] args)
    {
        // ── Parte 1: Verificar par o impar ──────────────────────────────
        Console.Write("Ingresa un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        // El operador módulo (%) devuelve el resto de la división.
        // Si el resto es 0, el número es par; de lo contrario, impar.
        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es PAR.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es IMPAR.");
        }

        // ── Parte 2: Bucle for del 1 al 10 ──────────────────────────────
        Console.WriteLine("\nNúmeros del 1 al 10:");

        // El bucle for recorre desde 1 hasta 10 (inclusive)
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i);

            // Añadimos coma separadora excepto en el último número
            if (i < 10)
                Console.Write(", ");
        }

        Console.WriteLine(); // Salto de línea al finalizar
    }
}
