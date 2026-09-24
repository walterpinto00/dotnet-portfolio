using System;
using System.Collections.Generic;
using System.Text;

namespace interfaz_01
{
    internal class CarritoCompras
    {
        public void Pagar(IMetodoPago metodo, double total)
        {
            Console.WriteLine("=== PROCESANDO PAGO ===");

            if (metodo.ProcesarPago(total))
            {
                Console.WriteLine($"✅ Pago exitoso");
                Console.WriteLine($"Comprobante: {metodo.ObtenerComprobante()}");
            }
            else
            {
                Console.WriteLine("❌ Pago fallido");
            }

            Console.WriteLine();
        }
    }
}
