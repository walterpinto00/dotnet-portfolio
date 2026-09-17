namespace Condicionales_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
        
            if (numero >= 0)
            {
                Console.WriteLine("Positivo (o cero)");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}
