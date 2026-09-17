namespace Vectores_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 12, 25, 8, 40, 17 };
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];
            }

            Console.WriteLine($"La suma total es: {suma}");
        }
    }
}
