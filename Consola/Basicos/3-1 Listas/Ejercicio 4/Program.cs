using System.Collections.Generic;

namespace Listas_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> estudiantes = new List<string>();

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Nombre del estudiante {i}: ");
                estudiantes.Add(Console.ReadLine());
            }

            Console.WriteLine("\nLista de estudiantes registrados:");
            foreach (string estudiante in estudiantes)
            {
                Console.WriteLine($"- {estudiante}");
            }
        }
    }
}
