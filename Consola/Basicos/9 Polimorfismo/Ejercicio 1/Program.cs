using System;

namespace Polimorfismo_Ejercicio1
{
    class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau guau!");
        }
    }

    class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla: ¡Miau miau!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal miPerro = new Perro();
            Animal miGato = new Gato();

            miPerro.HacerSonido();
            miGato.HacerSonido();
        }
    }
}
