using System;

namespace POO_Ejercicio1
{
    class Persona
    {
        public string Nombre;
        public int Edad;

        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Carlos";
            persona1.Edad = 25;
            persona1.Saludar();
        }
    }
}
