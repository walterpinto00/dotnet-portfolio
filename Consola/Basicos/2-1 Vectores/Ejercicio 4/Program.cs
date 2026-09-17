namespace Vectores_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una palabra o frase: ");
            string texto = Console.ReadLine().ToLower();
            int contador = 0;
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char letra in texto)
            {
                foreach (char vocal in vocales)
                {
                    if (letra == vocal)
                    {
                        contador++;
                    }
                }
            }

            Console.WriteLine($"Cantidad de vocales: {contador}");
        }
    }
}
