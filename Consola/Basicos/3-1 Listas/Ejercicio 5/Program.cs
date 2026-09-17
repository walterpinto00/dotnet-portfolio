using System.Collections.Generic;

namespace Listas_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 3, 8, 12, 5, 20, 7, 16, 9 };
            List<int> pares = new List<int>();

            foreach (int n in numeros)
            {
                if (n % 2 == 0)
                {
                    pares.Add(n);
                }
            }

            Console.WriteLine("Números pares:");
            foreach (int p in pares)
            {
                Console.Write(p + " ");
            }
            Console.WriteLine();
        }
    }
}
