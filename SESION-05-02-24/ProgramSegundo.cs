using System;
// EJERCICIO NRO 2.
namespace ConsolApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double Primer, Segund, Tercer;
            //==============================================================
            Console.WriteLine("Por favor. Ingrese el primer coeficiente: "); // A.
            Primer = Convert.ToDouble(Console.ReadLine());
            //==============================================================
            Console.WriteLine("Por favor Ingrese el segundo coeficiente: ");  // B.
            Segund = Convert.ToDouble(Console.ReadLine());
            //==============================================================
            Console.WriteLine("Por favor ingrese el tercer coeficiente: ");  // C.
            Tercer = Convert.ToDouble(Console.ReadLine());
            //==============================================================
            double d = (Segund * Segund - 4 * Primer * Tercer);
            if (d >= 0)
            {
                double re = (-Segund + Math.Sqrt(d) / (2 * Primer));
                double sed = (-Segund - Math.Sqrt(d) / (2 * Segund));
                //==============================================================
                Console.WriteLine("===== Soluciones... ======");
                Console.WriteLine($"re = {0} y sed = {1}", re, sed);
                //==============================================================
            }
            else
            {
                Console.WriteLine("Soluciones hechas por el programa..");
                Console.WriteLine("No pueden ser solucionadas..");
                Console.WriteLine("No son reales..");
            }
            //==============================================================
        }
    }
}
