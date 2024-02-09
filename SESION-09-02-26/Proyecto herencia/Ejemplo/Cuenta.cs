using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo
{
    public class CCuenta
    {
        // Atributos
        private string nombre;
        private string cuenta;
        private double saldo;
        private double tipoDeInterés;
        //Constructor
        public CCuenta()
        {

        }
        public CCuenta(string nom, string cue, double sal, double tipo)
        {
            Nombre = nom;
            Cuenta = cue;
            ingreso(sal);
            TipoDeInterés = tipo;
        }

        // Propiedades y métodos
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length == 0)
                {
                    System.Console.WriteLine("Error: cadena vacía");
                    return;
                }
                nombre = value;
            }
        }
        public string Cuenta
        {
            get
            {
                return cuenta;
            }
            set
            {
                if (value.Length == 0)
                {
                    System.Console.WriteLine("Error: cuenta no válida");
                    return;
                }
                cuenta = value;
            }
        }
        public double Saldo
        {
            get 
            {
                return saldo; 
            }
        }
        public void ingreso(double cantidad)
        {
            if (cantidad < 0)
            {
                System.Console.WriteLine("Error: cantidad negativa");
                return;
            }
            saldo = saldo + cantidad;
        }

        public void reintegro(double cantidad)
        {
            if (saldo - cantidad < 0)
            {
                System.Console.WriteLine("Error: no dispone de saldo");
                return;
            }
            saldo = saldo - cantidad;
        }
        public double TipoDeInterés
        {
            get
            {
                return tipoDeInterés;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Error: tipo no válido");
                    return;
                }
                tipoDeInterés = value;
            }
        }
    }
}
