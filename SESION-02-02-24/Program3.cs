using System;
class Program
{
    static void Main()
    {        
        int longitudMatriz = 5;
        int[] matriz = new int[longitudMatriz];
        
        for (int i = 0; i < longitudMatriz; i++)
        {
            Console.Write("Ingrese el valor para la posición {i + 1}: ");
            
            while (!int.TryParse(Console.ReadLine(), out matriz[i]))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                Console.Write("Ingrese el valor para la posición {i + 1}: ");
            }
        }
       
        Console.WriteLine("\nValores de la matriz:");
        for (int i = 0; i < longitudMatriz; i++)
        {
            Console.WriteLine($"Posición {i + 1}: {matriz[i]}");
        }
    }
}
