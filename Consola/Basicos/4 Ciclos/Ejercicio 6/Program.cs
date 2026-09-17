namespace Ciclos_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n=== MENÚ ===");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Mostrar fecha");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Hola Walter!");
                        break;
                    case 2:
                        Console.WriteLine(DateTime.Now.ToShortDateString());
                        break;
                    case 3:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            } while (opcion != 3);
        }
    }
}
