namespace Condicionales_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
        
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
        }
    }
}
