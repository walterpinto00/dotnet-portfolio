using System;
using System.Collections.Generic;
using System.Text;

namespace parctica_del_dia_24_08_2026
{
     class ProductoDigital : Producto
    {
        public double PrecioBase { get; set; }
        public int DiasLicencia { get; set; }

        public override double calcularPrecioFinal()
        {
            double descuento = DiasLicencia >= 365 ? 0.20 : 0;
            double iva = PrecioBase * 0.19;
            return (PrecioBase + iva) * (1 - descuento);
        }
    }
}
