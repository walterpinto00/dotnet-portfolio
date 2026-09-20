namespace TryCatch_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un correo electrónico: ");
            string correo = Console.ReadLine();

            try
            {
                if (!correo.Contains("@") || !correo.Contains("."))
                {
                    throw new ArgumentException("El correo no tiene un formato válido");
                }

                Console.WriteLine("Correo válido");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
