namespace Basico_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Primera nota: ");
            double nota1 = double.Parse(Console.ReadLine());
        
            Console.Write("Segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
        
            Console.Write("Tercera nota: ");
            double nota3 = double.Parse(Console.ReadLine());
        
            double promedio = (nota1 + nota2 + nota3) / 3;
        
            Console.WriteLine($"Promedio: {promedio:F2}");
        }
    }
}
