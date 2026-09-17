namespace Switch_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número del día (1-7): ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Día entre semana");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Fin de semana");
                    break;
                default:
                    Console.WriteLine("Día no válido");
                    break;
            }
        }
    }
}
