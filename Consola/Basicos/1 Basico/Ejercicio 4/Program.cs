namespace Basico_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());
        
            double area = Math.PI * radio * radio;
        
            Console.WriteLine($"Área del círculo: {area:F2}");
        }
    }
}
