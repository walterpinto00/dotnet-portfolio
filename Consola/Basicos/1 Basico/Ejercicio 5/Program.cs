namespace Basico_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Año de nacimiento: ");
            int anioNacimiento = int.Parse(Console.ReadLine());
        
            int anioFuturo = 2050;
            int edadFutura = anioFuturo - anioNacimiento;
        
            Console.WriteLine($"En {anioFuturo} tendrá {edadFutura} años");
        }
    }
}
