//EJERCICIO 4: Control de ventas del día. 
namespace prueba_de_desempeño
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaracion de varibles
            // guardan y acumulan 
            double totalVendido = 0;
            double ventaMayor = 0;
            4







            int cantidadVentas = 0;
            double venta = -1;

            while (venta != 0)//hasta que no ingrese un cero no para el bucle
            {
                Console.WriteLine("Ingrese valor de venta (0 para terminar): ");
                string input = Console.ReadLine();//
                
                if (double.TryParse(input, out venta))//convertir a número doble
                {
                    if (venta > 0)//validar si la venta es positiva
                    {
                        totalVendido += venta;
                        cantidadVentas++;
                        if (cantidadVentas == 1 || venta > ventaMayor)
                        {
                            ventaMayor = venta;
                        }
                    }
                        
                    {
                        Console.WriteLine("No se permiten valores negativos.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico válido.");
                }
            }


            // Mostrar resultados al final del bucle
            Console.WriteLine($"Total vendido: {totalVendido}");
            Console.WriteLine($"Venta mayor: {ventaMayor}");
            Console.WriteLine($"Cantidad de ventas: {cantidadVentas}");

            //promedio 
        }
    }
}