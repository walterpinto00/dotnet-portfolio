namespace Basico_Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Valor de la compra: $");
            double compra = double.Parse(Console.ReadLine());
        
            double iva = compra * 0.19;
            double total = compra + iva;
        
            Console.WriteLine($"IVA (19%): ${iva:F0}");
            Console.WriteLine($"Total a pagar: ${total:F0}");
        }
    }
}
