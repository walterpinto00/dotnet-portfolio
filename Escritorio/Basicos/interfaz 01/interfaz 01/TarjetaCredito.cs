using System;
using System.Collections.Generic;
using System.Text;

namespace interfaz_01
{
    // Cambiado de 'interface' a 'class'
    internal class TarjetaCredito : IMetodoPago, IValidable
    {
        private string numeroTarjeta;
        private string cvv;

        public TarjetaCredito(string num, string codigo)
        {
            numeroTarjeta = num;
            cvv = codigo;
        }

        public bool Validar()
        {
            return numeroTarjeta.Length == 16 && cvv.Length == 3;
        }

        public bool ProcesarPago(double monto)
        {
            if (!Validar())
                return false;

            Console.WriteLine($"💳 Procesando ${monto:F0} con tarjeta ****{numeroTarjeta.Substring(12)}");
            return true;
        }

        public void Reembolsar(double monto)
        {
            Console.WriteLine($"💳 Reembolsando ${monto:F0} a tarjeta");
        }

        public string ObtenerComprobante()
        {
            return $"TC-{DateTime.Now:yyyyMMddHHmmss}";
        }
    }
}