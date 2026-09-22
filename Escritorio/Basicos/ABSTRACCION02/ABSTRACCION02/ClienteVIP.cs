using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACCION02
{
    internal class ClienteVIP : Cliente
    {
        public string AsesorPersonal { get; set; }

        public override double CalcularDescuento(double totalCompra)
        {
            // DETALLE OCULTO: 20% de descuento
            return totalCompra * 0.20;
        }

        public override void RecibirCompra(string detalle)
        {
            Console.WriteLine($"🎁 {Nombre} recibirá su compra con entrega prioritaria");
            Console.WriteLine($"   Asesor: {AsesorPersonal}");
            Console.WriteLine($"   Detalle: {detalle}");
        }
    }
}
