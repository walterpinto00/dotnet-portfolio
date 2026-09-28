using System.Collections.Generic;

namespace BibliotecaApp.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalLibros { get; set; }
        public int LibrosPrestados { get; set; }
        public int TotalAutores { get; set; }
        public IEnumerable<PrestamoIndexViewModel> UltimosPrestamos { get; set; } = new List<PrestamoIndexViewModel>();
    }
}
