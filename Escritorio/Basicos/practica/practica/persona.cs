using System;
using System.Collections.Generic;
using System.Text;

namespace practica
{
    internal class Persona
    {
        //Atributos
        public string Nombre;

        public void saludar()
        {
            Console.WriteLine($"hola soy {Nombre}");
        }
    }
}
