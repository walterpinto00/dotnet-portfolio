using System;
using System.Collections.Generic;
using System.Text;

namespace parctica_del_dia_24_08_2026
{
    internal abstract class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public double PrecioBase { get; set; }

        public abstract double calcularPrecioFinal();

        public void mostrarInfo()
        {
            Console.WriteLine($"{Codigo} - {Nombre}");
            

        }
    }
}

