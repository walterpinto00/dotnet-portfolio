namespace Vectores_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 34, 12, 87, 45, 6, 99, 23 };
            int mayor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }

            Console.WriteLine($"El número mayor es: {mayor}");
        }
    }
}
