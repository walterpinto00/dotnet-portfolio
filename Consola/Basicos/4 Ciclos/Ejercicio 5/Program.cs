namespace Ciclos_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pinCorrecto = "4590";
            int intentos = 0;
            bool acceso = false;

            while (intentos < 3 && !acceso)
            {
                Console.Write("Ingrese su PIN: ");
                string pin = Console.ReadLine();

                if (pin == pinCorrecto)
                {
                    acceso = true;
                    Console.WriteLine("Acceso concedido");
                }
                else
                {
                    intentos++;
                    Console.WriteLine($"PIN incorrecto. Intentos restantes: {3 - intentos}");
                }
            }

            if (!acceso)
            {
                Console.WriteLine("Cuenta bloqueada");
            }
        }
    }
}
