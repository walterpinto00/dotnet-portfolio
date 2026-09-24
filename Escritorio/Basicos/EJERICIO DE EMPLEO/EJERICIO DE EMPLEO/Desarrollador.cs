using System;
using System.Collections.Generic;
using System.Text;

namespace EJERICIO_DE_EMPLEO
{
    internal class Desarrollador: Empleado  
    {
        //Atributos
        private string Lenguajeprincipal;
        private int  proyectoscompletos;
        //Constructor
        public Desarrollador(string nom, string id, string sal, string lenguaje, int proyectos) : base  (nom, id, sal)
        {
            Lenguajeprincipal = lenguaje;
            proyectoscompletos = proyectos;
        }



    }
}
