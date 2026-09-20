namespace TryCatch_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"El doble es: {numero * 2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida");
            }
            finally
            {
                Console.WriteLine("Proceso finalizado (esto siempre se ejecuta)");
            }
        }
    }
}
