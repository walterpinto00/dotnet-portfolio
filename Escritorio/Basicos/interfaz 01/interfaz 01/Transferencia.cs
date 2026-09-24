using System;
using System.Collections.Generic;
using System.Text;

namespace interfaz_01
{
    internal class Transferencia : IMetodoPago
    {
        private string cuentaOrigen;
        private string cuentaDestino;

        public Transferencia(string origen, string destino)
        {
            cuentaOrigen = origen;
            cuentaDestino = destino;
        }

        public bool ProcesarPago(double monto)
        {
            Console.WriteLine($"🏦 Transferencia ${monto:F0} de {cuentaOrigen} a {cuentaDestino}");
            return true;
        }

        public void Reembolsar(double monto)
        {
            Console.WriteLine($"🏦 Devolución ${monto:F0} a cuenta origen");
        }

        public string ObtenerComprobante()
        {
            return $"TR-{DateTime.Now:yyyyMMddHHmmss}";
        }
    }
}
