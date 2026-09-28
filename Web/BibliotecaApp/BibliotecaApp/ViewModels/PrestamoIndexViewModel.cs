using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.ViewModels
{
    public class PrestamoIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; } = string.Empty;

        [Display(Name = "Fecha de Préstamo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaPrestamo { get; set; }

        [Display(Name = "Fecha de Devolución")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? FechaDevolucion { get; set; }

        [Display(Name = "Libro")]
        public string TituloLibro { get; set; } = string.Empty;
        
        [Display(Name = "Autor del Libro")]
        public string AutorLibro { get; set; } = string.Empty;

        [Display(Name = "Días Prestado")]
        public int DiasPrestado { get; set; }

        [Display(Name = "Estado")]
        public string EstadoLibro { get; set; } = string.Empty;
    }
}
