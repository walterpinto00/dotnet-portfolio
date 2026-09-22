using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACCION02
{
    internal class SistemaVentas
    {
        public void ProcesarVenta(Cliente cliente, double totalCompra, string productos)
        {
            Console.WriteLine("\n=== PROCESANDO VENTA ===");

            cliente.MostrarDatos();

            // ════════════════════════════════════════════
            // ¡ABSTRACCIÓN EN ACCIÓN!
            // ════════════════════════════════════════════
            // El sistema NO SABE qué tipo de cliente es
            // Solo llama a los métodos y funciona
            // Los detalles de cada tipo están OCULTOS
            double descuento = cliente.CalcularDescuento(totalCompra);
            double totalPagar = totalCompra - descuento;

            Console.WriteLine($"Subtotal: ${totalCompra:F0}");
            Console.WriteLine($"Descuento: ${descuento:F0}");
            Console.WriteLine($"Total a pagar: ${totalPagar:F0}");

            cliente.RecibirCompra(productos);
        }
    }
}

