using System;
class Program
{
    static void Main()
    {        
        int[] Array = { 12, 5, 8, 23, 15, 7 };

        
        int May = EncontrarMayor(Array);
        int Men = EncontrarMenor(Array);

        Console.WriteLine($"El mayor elemento del arreglo es: {May}");
        Console.WriteLine($"El menor elemento del arreglo es: {Men}");
    }
    //==========================================================================================
    //==========================================================================================
    static int EncontrarMayor(int[] arreglo)
    {
        int mayor = arreglo[0];

        foreach (int elemento in arreglo)
        {
            if (elemento > mayor)
            {
                mayor = elemento;
            }
        }

        return mayor;
    }
    //==========================================================================================
    //==========================================================================================
    static int EncontrarMenor(int[] arreglo)
    {
        int menor = arreglo[0];

        foreach (int elemento in arreglo)
        {
            if (elemento < menor)
            {
                menor = elemento;
            }
        }
        return menor;
    }
}

















