using System;
using System.Collections.Generic;
using System.Text;

namespace parctica_del_dia_24_08_2026
{
    internal class Servicio : Producto
    {
        public double ValorHora { get; set; }
        public int Horas { get; set; } 
        public override double calcularPrecioFinal()
        {
            double subtotal = ValorHora * Horas;
            double iva = subtotal * 0.19;
            return subtotal + iva;
        }
    }
}
