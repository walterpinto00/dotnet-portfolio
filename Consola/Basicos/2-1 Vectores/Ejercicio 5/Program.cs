namespace Vectores_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };
            int[] invertido = new int[numeros.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                invertido[i] = numeros[numeros.Length - 1 - i];
            }

            Console.WriteLine("Arreglo invertido:");
            foreach (int n in invertido)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
