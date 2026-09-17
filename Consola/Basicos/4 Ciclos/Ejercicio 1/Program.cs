namespace Ciclos_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Base: "); int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Exponente: "); int exponente = int.Parse(Console.ReadLine());

            long resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }

            Console.WriteLine($"{baseNum}^{exponente} = {resultado}");
        }
    }
}
