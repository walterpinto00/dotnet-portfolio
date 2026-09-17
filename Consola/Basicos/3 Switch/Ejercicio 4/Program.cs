namespace Switch_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tipo de vehículo (carro/moto/bus/camion): ");
            string tipo = Console.ReadLine().ToLower();

            switch (tipo)
            {
                case "carro":
                    Console.WriteLine("Peaje: $12.000");
                    break;
                case "moto":
                    Console.WriteLine("Peaje: $5.000");
                    break;
                case "bus":
                    Console.WriteLine("Peaje: $20.000");
                    break;
                case "camion":
                    Console.WriteLine("Peaje: $35.000");
                    break;
                default:
                    Console.WriteLine("Vehículo no reconocido");
                    break;
            }
        }
    }
}
