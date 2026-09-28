using System.ComponentModel.DataAnnotations;

namespace BibliotecaApp.ViewModels
{
    public class LibroIndexViewModel
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

        [Display(Name = "Estado")]
        public string Estado { get; set; } = string.Empty;
    }
}
