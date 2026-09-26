using System;
using System.Collections.Generic;
using System.Text;

namespace parctica_del_dia_24_08_2026
{
    internal class CajaRegistradora
    {
        public void Cobrar(List<Producto> carrito)
        {
            Console.WriteLine("ticket de compra");
            double total = 0;
            foreach (Producto prod in carrito)
            {
                prod.mostrarInfo();
                double precio = prod.calcularPrecioFinal();
                Console.WriteLine($"Precio final: {precio:f0}");
                total += precio;
                Console.WriteLine();
            }
            Console.WriteLine($"Total a pagar: {total:f0}");
        }
    }
}
