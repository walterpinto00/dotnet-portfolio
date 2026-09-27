using System;
using System.Collections.Generic;
using System.Text;

namespace propiedades_de_encapsulacion
{
    internal class Empleado
    {
        // Usamos campos privados para proteger los datos internos
        private string nombre;
        private int edad;

        // Propiedad Nombre con validación (Encapsulamiento)
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío");
                if (value.Length < 2)
                    throw new ArgumentException("El nombre debe tener al menos 2 caracteres");
                nombre = value.Trim();
            }
        }

        // Propiedad Edad con validación (Encapsulamiento)
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value < 18 || value > 100)
                    throw new ArgumentException("La edad debe estar entre 18 y 100 años");
                edad = value;
            }
        }

        // CONSTRUCTOR: Inicializa el estado del objeto
        public Persona(string nombre, int edad)
        {
            // Usamos las propiedades (no los campos directamente) para aplicar validación
            Nombre = nombre;
            Edad = edad;
        }

        // MÉTODO ABSTRACTO: Define el "qué" sin el "cómo"
        // Las clases derivadas DEBEN implementar este método
        public abstract void MostrarInformacion();

        // MÉTODO VIRTUAL: Puede ser sobrescrito por clases derivadas
        public virtual string ObtenerDescripcion()
        {
            return $"{Nombre}, {Edad} años";
        }
    }
}
