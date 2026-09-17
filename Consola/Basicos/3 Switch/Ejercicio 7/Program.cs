namespace Switch_Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            string resultado = numero % 2 == 0 switch
            {
                true => "Par",
                false => "Impar"
            };

            Console.WriteLine($"El número es: {resultado}");
        }
    }
}
