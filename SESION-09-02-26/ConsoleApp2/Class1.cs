using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto de la clase COrdenador
            COrdenador miOrdenador = new COrdenador("Dell", "Intel", 2.5);

            // Mostrar información inicial
            miOrdenador.MostrarInformacion();

            // Encender el ordenador y la pantalla
            miOrdenador.Encender();
            miOrdenador.EncenderPantalla();

            // Mostrar información después de encender
            miOrdenador.MostrarInformacion();

            // Apagar la pantalla y luego el ordenador
            miOrdenador.ApagarPantalla();
            miOrdenador.Apagar();

            // Mostrar información final
            miOrdenador.MostrarInformacion();

            Console.ReadLine();
        }
    }
}
