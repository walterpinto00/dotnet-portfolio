using System;
using System.Collections.Generic;
using System.Text;

namespace interfaz_01
{
    internal interface IMetodoPago
    {
       
    bool ProcesarPago(double monto);
        void Reembolsar(double monto);
        string ObtenerComprobante();
    }

    interface IValidable
    {
        bool Validar();
    }
}

