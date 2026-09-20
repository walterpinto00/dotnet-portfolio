namespace TryCatch_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Dividendo: "); int a = int.Parse(Console.ReadLine());
                Console.Write("Divisor: "); int b = int.Parse(Console.ReadLine());

                int resultado = a / b;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: no se puede dividir entre cero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: ingrese valores numéricos válidos");
            }
        }
    }
}
