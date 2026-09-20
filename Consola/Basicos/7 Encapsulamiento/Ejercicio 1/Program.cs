using System;

namespace Encapsulamiento_Ejercicio1
{
    class CuentaBancaria
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set 
            {
                if (value >= 0)
                    saldo = value;
                else
                    Console.WriteLine("El saldo no puede ser negativo.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();
            cuenta.Saldo = 1500.50;
            Console.WriteLine($"Saldo actual: ");
        }
    }
}
