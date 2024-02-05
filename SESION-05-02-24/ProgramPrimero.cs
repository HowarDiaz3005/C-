using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// EJERCICIO NRO 1.
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== BIENVENIDO A SU PROGRAMA ( TIENDA WALMART) ====");
            Console.WriteLine("ARTICULOS DISPOBILES\n1.ABANICOS\n2.RELOJES\n3.CELULARES");
            Console.WriteLine("¿Que desea llevar?");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad que desee llevar: ");
                    int art = Convert.ToInt32(Console.ReadLine());
                    if (art >= 4 || art < 5)
                    {
                        Console.WriteLine("Solo se le cobraran tres. ");
                        // Datos ingresados
                        Console.WriteLine("El precio de los abanicos es ( 1700 )");

                        int set = (art * 1700);
                        Console.WriteLine("Su compra de " + set + "  exede los 300 cordobas, valoraremos los Vales");
                        int lok = (set / 100);

                        Console.WriteLine("El total a pagar serian" + set);
                        Console.WriteLine("Obtuvo" + lok + " de Vales.");
                        Console.WriteLine("Vales en cordobas serian [" + (lok * 10) + "]" );
                        Console.WriteLine("===== MUCHAS GRACIAS POR SU COMPRA  =====");

                    }
                    else if (art > 5)
                    {
                        
                        Console.WriteLine("Disculpe, no se le permiten mas de 5 articulos.");
                        Console.WriteLine("Vuelva a ingresar la cantidad de articulos que desea llevar");
                        int la = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El precio de los abanicos es ( 1700 )");

                        int sat = (la * 1700);
                        Console.WriteLine("Su compra de " + sat + "  exede los 300 cordobas, valoraremos los Vales");
                        int lak = (sat / 100);

                        Console.WriteLine("El total a pagar serian" + sat);
                        Console.WriteLine("Obtuvo" + lak + " de Vales.");
                        Console.WriteLine("Vales en cordobas serian [" + (lak * 10) + "]");
                        Console.WriteLine("===== MUCHAS GRACIAS POR SU COMPRA  =====");
                    }
                    break;
                //==========================================================================================================================
                //==========================================================================================================================
                //==========================================================================================================================
                case 2:
                    Console.WriteLine("Ingrese la cantidad que desee llevar: ");
                    int pri = Convert.ToInt32(Console.ReadLine());
                    if (pri >= 4 || pri < 5)
                    {
                        Console.WriteLine("Solo se le cobraran tres. ");
                        // Datos ingresados
                        Console.WriteLine("El precio de los Relojes es ( 3500 )");

                        int sut = (pri * 3500);
                        Console.WriteLine("Su compra de " + sut + "  exede los 300 cordobas, valoraremos los Vales");
                        int lrk = (sut / 100);

                        Console.WriteLine("El total a pagar serian" + sut);
                        Console.WriteLine("Obtuvo" + lrk + " de Vales.");
                        Console.WriteLine("Vales en cordobas serian [" + (lrk * 10) + "]");
                        Console.WriteLine("===== MUCHAS GRACIAS POR SU COMPRA  =====");

                    }
                    else if (pri > 5)
                    {                       
                        Console.WriteLine("Disculpe, no se le permiten mas de 5 articulos.");
                        Console.WriteLine("Vuelva a ingresar la cantidad de articulos que desea llevar");
                        int la = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El precio de los Relojes es ( 3500 )");

                        int sit = (la * 3500);
                        Console.WriteLine("Su compra de " + sit + "  exede los 300 cordobas, valoraremos los Vales");
                        int lqk = (sit / 100);

                        Console.WriteLine("El total a pagar serian" + sit);
                        Console.WriteLine("Obtuvo" + lqk + " de Vales.");
                        Console.WriteLine("Vales en cordobas serian [" + (lqk * 10) + "]");
                        Console.WriteLine("===== MUCHAS GRACIAS POR SU COMPRA  =====");
                    }
                    break;
                //==========================================================================================================================
                //==========================================================================================================================
                //==========================================================================================================================
                case 3:

                    Console.WriteLine("Ingrese la cantidad que desee llevar: ");
                    int pre = Convert.ToInt32(Console.ReadLine());
                    if (pre >= 4 || pre < 5)
                    {
                        Console.WriteLine("Solo se le cobraran tres. ");
                        // Datos ingresados
                        Console.WriteLine("El precio de los Celulares es ( 12000 )");

                        int sdt = (pre * 12000);
                        Console.WriteLine("Su compra de " + sdt + "  exede los 300 cordobas, valoraremos los Vales");
                        int lqq = (sdt / 100);

                        Console.WriteLine("El total a pagar serian" + sdt);
                        Console.WriteLine("Obtuvo" + lqq + " de Vales.");
                        Console.WriteLine("Vales en cordobas serian [" + (lqq * 10) + "]");
                        Console.WriteLine("===== MUCHAS GRACIAS POR SU COMPRA  =====");
                    }
                    else if (pre > 5)
                    {
                        Console.WriteLine("Disculpe, no se le permiten mas de 5 articulos.");
                        Console.WriteLine("Vuelva a ingresar la cantidad de articulos que desea llevar");
                        int er = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El precio de los Celulares es ( 12000 )");

                        int sit = (er * 12000);
                        Console.WriteLine("Su compra de " + sit + "  exede los 300 cordobas, valoraremos los Vales");
                        int lqk = (sit / 100);

                        Console.WriteLine("El total a pagar serian" + sit);
                        Console.WriteLine("Obtuvo" + lqk + " de Vales.");
                        Console.WriteLine("Vales en cordobas serian [" + (lqk * 10) + "]");
                        Console.WriteLine("===== MUCHAS GRACIAS POR SU COMPRA  =====");
                    }
                    break;
            }
        }
    }
}
