using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.ViewModels
{
    public class CrearEditarPrestamoViewModel
    {
        [Required(ErrorMessage = "El nombre del usuario es obligatorio")]
        [StringLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de préstamo es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Préstamo")]
        public DateTime FechaPrestamo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Devolución")]
        public DateTime? FechaDevolucion { get; set; }

        [Required(ErrorMessage = "El libro es obligatorio")]
        [Display(Name = "Libro")]
        public int LibroId { get; set; }
    }
}
