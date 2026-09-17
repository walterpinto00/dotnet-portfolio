namespace Ciclos_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Límite inferior: "); int inicio = int.Parse(Console.ReadLine());
            Console.Write("Límite superior: "); int fin = int.Parse(Console.ReadLine());

            Console.WriteLine("Números pares en el rango:");
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
