namespace TryCatch_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Número 1: "); double n1 = double.Parse(Console.ReadLine());
                Console.Write("Operador (+,-,*,/): "); string op = Console.ReadLine();
                Console.Write("Número 2: "); double n2 = double.Parse(Console.ReadLine());

                double resultado = op switch
                {
                    "+" => n1 + n2,
                    "-" => n1 - n2,
                    "*" => n1 * n2,
                    "/" => n1 / n2,
                    _ => throw new InvalidOperationException("Operador no válido")
                };

                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: valores numéricos inválidos");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: división entre cero");
            }
        }
    }
}
