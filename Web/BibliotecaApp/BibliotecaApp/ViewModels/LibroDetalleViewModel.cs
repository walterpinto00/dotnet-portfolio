using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.ViewModels
{
    public class LibroDetalleViewModel
    {
        public int Id { get; set; }
        
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;
        
        [Display(Name = "ISBN")]
        public string ISBN { get; set; } = string.Empty;
        
        [Display(Name = "Año de Publicación")]
        public int AnioPublicacion { get; set; }
        
        [Display(Name = "Autor")]
        public string NombreAutor { get; set; } = string.Empty;
        
        // You could include list of loans here if needed
        public int NumeroPrestamos { get; set; }
    }
}
