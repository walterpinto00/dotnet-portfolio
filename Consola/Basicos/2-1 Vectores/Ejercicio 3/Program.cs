namespace Vectores_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = { 4.5, 3.8, 2.9, 4.0, 3.5 };
            double suma = 0;

            foreach (double nota in notas)
            {
                suma += nota;
            }

            double promedio = suma / notas.Length;
            Console.WriteLine($"El promedio es: {promedio:F2}");
        }
    }
}
