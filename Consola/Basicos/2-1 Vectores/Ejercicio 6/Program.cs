namespace Vectores_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = { { 1, 2 }, { 3, 4 } };
            int[,] matrizB = { { 5, 6 }, { 7, 8 } };
            int[,] resultado = new int[2, 2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        resultado[i, j] += matrizA[i, k] * matrizB[k, j];
                    }
                }
            }

            Console.WriteLine("Resultado de la multiplicación:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(resultado[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
