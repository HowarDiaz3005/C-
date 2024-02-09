using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
        public class Test
        {
            public static void Main(string[] args)
            {
            CCuenta cuenta01 = new CCuenta();
            CCuenta cuenta02 = new CCuenta("Un nombre", "Una cuenta",
            6000, 3.5);

                cuenta01.Nombre = "Un nombre";
                cuenta01.Cuenta = "Una cuenta";
                cuenta01.TipoDeInterés = 2.5;
                cuenta01.ingreso(12000);
                cuenta01.reintegro(3000);
                System.Console.WriteLine(cuenta01.Nombre);
                System.Console.WriteLine(cuenta01.Cuenta);
                System.Console.WriteLine(cuenta01.Saldo);
                System.Console.WriteLine(cuenta01.TipoDeInterés);
            }
        }
    
}
