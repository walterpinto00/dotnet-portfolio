using System.Collections.Generic;

namespace Listas_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string> { "Ana", "Luis", "Carlos", "Marta", "Pedro" };

            Console.Write("Nombre a eliminar: ");
            string nombre = Console.ReadLine();

            if (nombres.Remove(nombre))
            {
                Console.WriteLine($"'{nombre}' fue eliminado de la lista");
            }
            else
            {
                Console.WriteLine("Ese nombre no está en la lista");
            }

            Console.WriteLine("Lista actual:");
            foreach (string n in nombres)
            {
                Console.WriteLine($"- {n}");
            }
        }
    }
}
