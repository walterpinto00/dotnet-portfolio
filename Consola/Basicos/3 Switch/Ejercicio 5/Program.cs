namespace Switch_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nivel de riesgo (1, 2 o 3): ");
            int nivel = int.Parse(Console.ReadLine());

            switch (nivel)
            {
                case 1:
                    Console.WriteLine("Riesgo bajo");
                    break;
                case 2:
                    Console.WriteLine("Riesgo medio");
                    break;
                case 3:
                    Console.WriteLine("Riesgo alto");
                    break;
                default:
                    Console.WriteLine("Nivel no válido");
                    break;
            }
        }
    }
}
