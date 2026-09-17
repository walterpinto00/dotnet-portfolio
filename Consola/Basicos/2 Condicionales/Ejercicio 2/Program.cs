namespace Condicionales_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
        
            if (numero % 5 == 0)
            {
                Console.WriteLine("El número es divisible entre 5");
            }
        }
    }
}
