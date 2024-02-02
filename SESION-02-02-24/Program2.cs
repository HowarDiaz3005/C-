using System;
class Program
{
    static void Main()
    {       
        int Fil = 2;
        int columnas = 3;        
        int[,] matrizA = new int[Fil, columnas];
        int[,] matrizB = new int[Fil, columnas];

        
        Console.WriteLine("Ingrese los valores para la matriz A:");
        PedirValoresMatrizInicial(matrizA, Fil, columnas);

        
        Console.WriteLine("\nIngrese los valores para la matriz B:");
        PedirValoresMatrizInicial(matrizB, Fil, columnas);

        
        int[,] matrizSuma = SumarMatricesIngresadas(matrizA, matrizB, Fil, columnas);

        
        Console.WriteLine("\nMatriz resultante de la suma de ambas matrices:");
        MostrarMatrizConcluida(matrizSuma, Fil, columnas);
    }
    //==========================================================================================
    //==========================================================================================

    static void PedirValoresMatrizInicial(int[,] matriz, int filas, int columnas)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write("Ingrese el valor para la posición [{i + 1}, {j + 1}]: ");
                
                while (!int.TryParse(Console.ReadLine(), out matriz[i, j]))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    Console.Write("Ingrese el valor para la posición [{i + 1}, {j + 1}]: ");
                }
            }
        }
    }
    //==========================================================================================
    //==========================================================================================
    static int[,] SumarMatricesIngresadas(int[,] matrizA, int[,] matrizB, int filas, int columnas)
    {
        int[,] resultado = new int[filas, columnas];

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                resultado[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }

        return resultado;
    }
    //==========================================================================================
    //==========================================================================================
    static void MostrarMatrizConcluida(int[,] matriz, int filas, int columnas)
    {
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"{matriz[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}
