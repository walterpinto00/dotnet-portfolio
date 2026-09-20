using System;

namespace Herencia_Ejercicio1
{
    class Vehiculo
    {
        public string Marca { get; set; }
        
        public void Arrancar()
        {
            Console.WriteLine("El vehículo está arrancando...");
        }
    }

    class Coche : Vehiculo
    {
        public int NumeroPuertas { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coche miCoche = new Coche();
            miCoche.Marca = "Toyota";
            miCoche.NumeroPuertas = 4;
            
            Console.WriteLine($"Coche Marca: {miCoche.Marca}, Puertas: {miCoche.NumeroPuertas}");
            miCoche.Arrancar();
        }
    }
}
