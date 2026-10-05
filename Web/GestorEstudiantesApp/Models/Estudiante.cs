using System.ComponentModel.DataAnnotations;

namespace GestorEstudiantesApp.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        [Required, Display(Name = "Nombre Completo")] public string Nombre { get; set; }
        [Required] public string Programa { get; set; }
        [Range(0, 10)] public double Promedio { get; set; }
        public string Estado { get; set; } = "Activo";
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
    }
}
