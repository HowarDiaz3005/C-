using System;
class Program
{
    static void Main()
    { 
        string[] nombres = new string[5];
        double[] sueldos = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese el nombre del empleado [ de uno en uno ]: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Ingrese el sueldo del empleado:");
            
            while (!double.TryParse(Console.ReadLine(), out sueldos[i]))
            {
                Console.WriteLine("Por favor, ingrese un número válido para el sueldo.");
                Console.Write("Ingrese el sueldo de {nombres[i]}: ");
            }
        }
        Console.WriteLine("\nLISTADO DE EMPLEADOS CON  SUS DEBIDOS SUELDOS.");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"{nombres[i]} - Sueldo: {sueldos[i]:C}");
        }
    }
}
