namespace Condicionales_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatura actual (°C): ");
            double temperatura = double.Parse(Console.ReadLine());
        
            if (temperatura > 35)
            {
                Console.WriteLine("Alerta: temperatura muy alta");
            }
        }
    }
}
