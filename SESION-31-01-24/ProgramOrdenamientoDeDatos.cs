using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[9];
        //======================================================
        // Declarandole al usuario para  que ingrese los numeros.
        //======================================================
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine("========================");
            Console.Write("Ingrese números [ + otro ]: ");
            Console.WriteLine("\n========================");
            if (int.TryParse(Console.ReadLine(), out numeros[i]))
            {

            }
            //====================================================================
            // Validando las entradas del usuario, para proseguir con el programa.
            //====================================================================
            else
            {
                Console.WriteLine("===========================================");
                Console.WriteLine("Por favor, ingrese un número entero válido.");
                Console.WriteLine("===========================================");
                i--;
            }
        }
        //=====================================
        // Inicializo las variables desde cero.
        //=====================================
        int sumaPositivos = 0;
        int sumaNegativos = 0;

        foreach (int numero in numeros)
        {
            if (numero > 0)
            {
                sumaPositivos += numero;
            }
            else if (numero < 0)
            {
                sumaNegativos += numero;
            }
        }
        Console.WriteLine($"====================================================");
        Console.WriteLine($"La suma de los números positivos es: {sumaPositivos}");
        Console.WriteLine($"La suma de los números negativos es: {sumaNegativos}");
        Console.WriteLine($"====================================================");
        Console.ReadLine();
    }
}
