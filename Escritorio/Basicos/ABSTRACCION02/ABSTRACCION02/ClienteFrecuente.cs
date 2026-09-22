using System;
using System.Collections.Generic;
using System.Text;

namespace ABSTRACCION02
{
    internal class ClienteFrecuente : Cliente
    {
        public int PuntosAcumulados { get; set; }
        public override double CalcularDescuento(double totalCompra)
        {
            return totalCompra * 0.10;
        }
        public override void RecibirCompra(string detalle)
        {
            Console.WriteLine($"📦 {Nombre} recibirá su compra en domicilio (gratis)");
            PuntosAcumulados += 100;
            Console.WriteLine($"   Puntos acumulados: {PuntosAcumulados}");
        }
    }
}