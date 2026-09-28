using System.Collections.Generic;

namespace BibliotecaApp.ViewModels
{
    public class PaginacionViewModel<T>
    {
        public IEnumerable<T> Items { get; set; } = new List<T>();
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
        public int TotalElementos { get; set; }
        
        public bool TienePaginaAnterior => PaginaActual > 1;
        public bool TienePaginaSiguiente => PaginaActual < TotalPaginas;
    }
}
