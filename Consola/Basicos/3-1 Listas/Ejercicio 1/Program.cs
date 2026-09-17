using System.Collections.Generic;

namespace Listas_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> compras = new List<string>();

            compras.Add("Arroz");
            compras.Add("Leche");
            compras.Add("Huevos");
            compras.Add("Pan");

            Console.WriteLine("Lista de compras:");
            foreach (string item in compras)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
