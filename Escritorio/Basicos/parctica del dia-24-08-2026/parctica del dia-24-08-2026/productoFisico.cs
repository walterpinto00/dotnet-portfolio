using System;
using System.Collections.Generic;
using System.Text;

namespace parctica_del_dia_24_08_2026
{
    internal class ProductoFisico : Producto
    {
        public double PrecioBase { get; set; }
        public double Peso { get; set; }

        public override double calcularPrecioFinal()
        {
            double envio = Peso  * 1000;
            double iva= PrecioBase * 0.19;
            return PrecioBase + envio + iva;
        }
    }
}
