namespace Basico_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos dólares quiere convertir? ");
            double dolares = double.Parse(Console.ReadLine());
        
            double trm = 4100;
            double pesos = dolares * trm;
        
            Console.WriteLine($"Equivalente en pesos: ${pesos:F0}");
        }
    }
}
