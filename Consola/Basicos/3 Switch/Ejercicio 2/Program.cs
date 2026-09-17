namespace Switch_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Color del semáforo (rojo/amarillo/verde): ");
            string color = Console.ReadLine().ToLower();

            switch (color)
            {
                case "rojo":
                    Console.WriteLine("Deténgase");
                    break;
                case "amarillo":
                    Console.WriteLine("Precaución");
                    break;
                case "verde":
                    Console.WriteLine("Siga");
                    break;
                default:
                    Console.WriteLine("Color no reconocido");
                    break;
            }
        }
    }
}
