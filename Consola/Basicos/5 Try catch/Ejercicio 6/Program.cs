namespace TryCatch_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            int maxIntentos = 3;
            bool exito = false;

            while (intentos < maxIntentos && !exito)
            {
                try
                {
                    Console.Write("Ingrese un número entero: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Número ingresado correctamente: {numero}");
                    exito = true;
                }
                catch (FormatException)
                {
                    intentos++;
                    Console.WriteLine($"Entrada inválida. Intento {intentos} de {maxIntentos}");
                }
            }

            if (!exito)
            {
                Console.WriteLine("Se agotaron los intentos");
            }
        }
    }
}
