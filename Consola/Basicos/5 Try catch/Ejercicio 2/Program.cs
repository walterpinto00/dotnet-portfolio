namespace TryCatch_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");

            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                if (edad >= 0 && edad < 120)
                {
                    Console.WriteLine($"Edad válida: {edad} años");
                }
                else
                {
                    Console.WriteLine("La edad ingresada está fuera de rango");
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido");
            }
        }
    }
}
