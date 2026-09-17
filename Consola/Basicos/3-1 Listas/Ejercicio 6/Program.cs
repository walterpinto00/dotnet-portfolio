using System.Collections.Generic;

namespace Listas_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productos = new List<string> { "Teclado", "Audífonos", "Mouse", "Monitor", "Cámara" };

            productos.Sort();

            Console.WriteLine("Productos ordenados alfabéticamente:");
            foreach (string producto in productos)
            {
                Console.WriteLine($"- {producto}");
            }
        }
    }
}
