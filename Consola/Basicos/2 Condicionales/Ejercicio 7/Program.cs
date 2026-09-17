namespace Condicionales_Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Peso (kg): "); double peso = double.Parse(Console.ReadLine());
            Console.Write("Altura (m): "); double altura = double.Parse(Console.ReadLine());
        
            double imc = peso / (altura * altura);
        
            string estado = (imc > 25) ? "Riesgo" : "Saludable";
        
            Console.WriteLine($"IMC: {imc:F2} - Estado: {estado}");
        }
    }
}
