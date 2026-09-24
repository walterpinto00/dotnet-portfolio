using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EJERICIO_DE_EMPLEO
{
    internal class Empleado
    {
        
            protected string nombre;
            protected int identificacion;

            protected string salariobase;

        public Empleado(string nom, string id, string sal)
        {
            nombre = nom;
            identificacion = Convert.ToInt32(id);
            salariobase = sal;
           

        
        }
        //constructor
        public virtual double CalcularSalario()
        {
            return Convert.ToDouble(salariobase);
        }
        //metodo que arroja la info
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"ID: {identificacion}");
            Console.WriteLine($"Salario: ${CalcularSalario():F0}");
        }
    }

}
