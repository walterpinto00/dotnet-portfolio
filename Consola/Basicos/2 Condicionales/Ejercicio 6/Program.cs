namespace Condicionales_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lado A: "); int ladoA = int.Parse(Console.ReadLine());
            Console.Write("Lado B: "); int ladoB = int.Parse(Console.ReadLine());
            Console.Write("Lado C: "); int ladoC = int.Parse(Console.ReadLine());
        
            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("Equilátero");
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("Isósceles");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
        }
    }
}
