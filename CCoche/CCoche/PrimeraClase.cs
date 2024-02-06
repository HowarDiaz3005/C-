using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCoche
{
  class PrimeraClase
  {
    static void Main(string[] args)
    {                
        CCoche miCoche = new CCoche("Toyota", "Corolla", "Rojo");
              
        miCoche.ArrancarMotor();
        miCoche.Acelerar(50);
        miCoche.CambiarVelocidad(80);
        miCoche.Frenar(30);
        miCoche.PararMotor();

        Console.ReadLine();
    }
  }
}

