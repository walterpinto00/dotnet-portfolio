namespace Switch_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tamaño de pizza (P/M/G): ");
            string tamano = Console.ReadLine().ToUpper();
            double precio;

            switch (tamano)
            {
                case "P":
                    precio = 18000;
                    break;
                case "M":
                    precio = 25000;
                    break;
                case "G":
                    precio = 32000;
                    break;
                default:
                    Console.WriteLine("Tamaño no válido");
                    return;
            }

            Console.WriteLine($"Precio: ${precio:N0}");
        }
    }
}
