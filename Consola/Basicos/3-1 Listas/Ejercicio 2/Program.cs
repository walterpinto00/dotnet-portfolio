using System.Collections.Generic;

namespace Listas_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            int suma = 0;

            foreach (int n in numeros)
            {
                suma += n;
            }

            Console.WriteLine($"La suma es: {suma}");
        }
    }
}
