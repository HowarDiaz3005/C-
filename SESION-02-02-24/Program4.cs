using System;
class Program
{
    static void Main()
    {
        int[] edades = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese la edad del estudiante [ de uno en uno ]: ");

            while (!int.TryParse(Console.ReadLine(), out edades[i]))
            {
                Console.WriteLine("Por favor, ingrese una edad válida.");
                Console.Write("Ingrese la edad del estudiante [ de uno en uno ]: ");
            }
        }

        int sumatoriaEdades = 0;
        foreach (int edad in edades)
        {
            sumatoriaEdades += edad;
        }
        Console.WriteLine($"La sumatoria de edades es: {sumatoriaEdades}");
    }
}

