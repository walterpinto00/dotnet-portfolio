namespace Ciclos_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la altura del triángulo: ");
            int altura = int.Parse(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
