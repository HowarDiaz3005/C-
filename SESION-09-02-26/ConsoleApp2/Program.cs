using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class COrdenador
    {

        private string marca;
        private string procesador;
        private double peso;
        private bool encendido;
        private bool pantallaActiva;

        //=================================================================================================
        public COrdenador(string marca, string procesador, double peso)
        {
            Console.WriteLine("===============================");
            this.marca = marca;
            this.procesador = procesador;
            this.peso = peso;
            this.encendido = false; 
            this.pantallaActiva = false;
            Console.WriteLine("===============================");
        }

        //=================================================================================================
        public void Encender()
        {
            encendido = true;
            Console.WriteLine("===============================");
            Console.WriteLine("El ordenador ha sido encendido.");
            Console.WriteLine("===============================");
        }

        //=================================================================================================
        public void Apagar()
        {
            if (pantallaActiva)
            {
                ApagarPantalla(); 
            }
            encendido = false;
            Console.WriteLine("===============================");
            Console.WriteLine("El ordenador ha sido apagado.");
            Console.WriteLine("===============================");
        }

        //=================================================================================================
        public void EncenderPantalla()
        {
            if (!encendido)
            {
                Console.WriteLine("==================================================================");
                Console.WriteLine("No se puede encender la pantalla porque el ordenador está apagado.");
                Console.WriteLine("==================================================================");
            }
            else
            {
                pantallaActiva = true;
                Console.WriteLine("===============================");
                Console.WriteLine("La pantalla ha sido activada.");
                Console.WriteLine("===============================");
            }
        }


        public void ApagarPantalla()
        {
            pantallaActiva = false;
            Console.WriteLine("===============================");
            Console.WriteLine("La pantalla ha sido apagada.");
            Console.WriteLine("===============================");
        }

        //=================================================================================================
        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Procesador: {procesador}");
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine($"Estado: {(encendido ? "Encendido" : "Apagado")}");
            Console.WriteLine($"Pantalla: {(pantallaActiva ? "Activa" : "Inactiva")}");
            Console.WriteLine("===============================");
        }
    }
}
