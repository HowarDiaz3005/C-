using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// set-2024... 
namespace CCoche
{
        public class CCoche
        {
            private string marca;
            private string modelo;
            private string color;
            private bool motorEncendido;
            private int velocidadActual;
        
            public CCoche(string marca, string modelo, string color)
            {
                this.marca = marca;
                this.modelo = modelo;
                this.color = color;
                this.motorEncendido = false;
                this.velocidadActual = 0;
            }

        //===================================================================
        //===================================================================
        //===================================================================
        public void ArrancarMotor()
            {
                if (!motorEncendido)
                {
                    Console.WriteLine("Arrancando el motor...");
                    motorEncendido = true;
                }
                else
                {
                    Console.WriteLine("El motor ya está encendido.");
                }
            }
        //===================================================================
        //===================================================================
        //===================================================================

        public void PararMotor()
            {
                if (motorEncendido)
                {
                    Console.WriteLine("Parando el motor...");
                    motorEncendido = false;
                    velocidadActual = 0;
                }
                else
                {
                    Console.WriteLine("El motor ya está apagado.");
                }
            }
        //===================================================================
        //===================================================================
        //===================================================================
        public void CambiarVelocidad(int nuevaVelocidad)
            {
                if (motorEncendido)
                {
                    if (nuevaVelocidad >= 0)
                    {
                        velocidadActual = nuevaVelocidad;
                        Console.WriteLine($"Cambiando velocidad a {velocidadActual} km/h.");
                    }
                    else
                    {
                        Console.WriteLine("La velocidad no puede ser negativa.");
                    }
                }
                else
                {
                    Console.WriteLine("No se puede cambiar la velocidad porque el motor está apagado.");
                }
            }
        //===================================================================
        //===================================================================
        //===================================================================
        public void Acelerar(int incremento)
            {
                if (motorEncendido)
                {
                    if (velocidadActual + incremento >= 0)
                    {
                        velocidadActual += incremento;
                        Console.WriteLine($"Acelerando. Velocidad actual: {velocidadActual} km/h.");
                    }
                    else
                    {
                        Console.WriteLine("No se puede acelerar más, la velocidad no puede ser negativa.");
                    }
                }
                else
                {
                    Console.WriteLine("No se puede acelerar porque el motor está apagado.");
                }
            }
        //===================================================================
        //===================================================================
        //===================================================================
        public void Frenar(int decremento)
            {
                if (motorEncendido)
                {
                    if (velocidadActual - decremento >= 0)
                    {
                        velocidadActual -= decremento;
                        Console.WriteLine($"Frenando. Velocidad actual: {velocidadActual} km/h.");
                    }
                    else
                    {
                        Console.WriteLine("El coche ya está detenido.");
                    }
                }
                else
                {
                    Console.WriteLine("No se puede frenar porque el motor está apagado.");
                }
            }
        }
}


