namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            string nombre = "walter";
            int edad = 19;
            double estatura = 1.75;
            bool esEstudiante = true;
            char inicial = 'w';

            // Mostrar variables en pantalla
            Console.WriteLine("=== INFORMACIÓN PERSONAL ===");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Estatura: " + estatura + " metros");
            Console.WriteLine("¿Es estudiante?: " + esEstudiante);
            Console.WriteLine("Inicial: " + inicial);
        }
    }
}
