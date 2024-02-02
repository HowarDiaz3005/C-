using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Ejemplo2 de vectores con la función Lenght";
        Double SumaNotas = 0, Promedio;
        Double[] Notas = { 10, 7.2, 8.5, 9.1, 6.5 };
        String[] Alumnos = { "luán Perez", "Toño", "Chepe", "Rodrigo", "Marisol" };
        for (int i = 0; i < Notas.Length; i++)
        {
            Console.WriteLine("\nLa nota de {0} es: {1}", Alumnos[i], Notas[i]);
        }
        for (int i = 0; i < Notas.Length; i++)
        {
            SumaNotas = SumaNotas + Notas[i];
        }
        Promedio = (SumaNotas / 5);
        Console.WriteLine("");
        Console.WriteLine("\n\tLa suma de todas las notas es: " + SumaNotas);
        Console.WriteLine("\n\tEl promedio de las notas es: " + Math.Round(Promedio, 2));
        Console.ReadKey();
    }
}