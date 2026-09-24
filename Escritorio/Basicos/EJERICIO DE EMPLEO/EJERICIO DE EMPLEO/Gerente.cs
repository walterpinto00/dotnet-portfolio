using EJERICIO_DE_EMPLEO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO_DE_EMPLEO
{
    internal class Gerente : Empleado
    {
        private int empleadosACargo;

        
        public Gerente(string nom, string id, double salario, int empleados) : base(nom, id, salario.ToString())
        {
         
            empleadosACargo = empleados;
        }

      
        public override double CalcularSalario()
        {
            double bono = empleadosACargo * 50000;
            return Convert.ToDouble(salariobase) + bono;
        }
        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Tipo: Gerente");
            Console.WriteLine($"Empleados a cargo: {empleadosACargo}");
        }
    }
}