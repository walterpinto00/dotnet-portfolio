using EJERCICIO_DE_EMPLEO;

namespace EJERICIO_DE_EMPLEO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DESARROLLADOR ===");
            Desarrollador dev = new Desarrollador("Ana", "D001", "3000000", "C#", 5);
            dev.MostrarInfo();
            Console.WriteLine("=== GERENTE ===");
            Gerente gerente = new Gerente("Carlos", "G001", "5000000", 10);
            gerente.MostrarInfo();
        }
    }
}
