namespace Switch_Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un correo electrónico: ");
            string correo = Console.ReadLine();

            string resultado = correo.Contains("@") && correo.Contains(".") switch
            {
                true => "Correo con formato válido",
                false => "Correo con formato inválido"
            };

            Console.WriteLine(resultado);
        }
    }
}
