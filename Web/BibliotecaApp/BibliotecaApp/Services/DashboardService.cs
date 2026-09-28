using BibliotecaApp.Data;
using BibliotecaApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly ApplicationDbContext _context;

        public DashboardService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DashboardViewModel> ObtenerDashboardAsync()
        {
            var totalLibros = await _context.Libros.CountAsync();
            var totalAutores = await _context.Autores.CountAsync();
            
            // Un libro está prestado si tiene algún préstamo sin fecha de devolución
            var librosPrestados = await _context.Libros
                .Where(l => l.Prestamos.Any(p => p.FechaDevolucion == null))
                .CountAsync();

            var ultimosPrestamos = await _context.Prestamos
                .Include(p => p.Libro)
                    .ThenInclude(l => l!.Autor)
                .OrderByDescending(p => p.FechaPrestamo)
                .Take(5)
                .Select(p => new PrestamoIndexViewModel
                {
                    Id = p.Id,
                    NombreUsuario = p.NombreUsuario,
                    FechaPrestamo = p.FechaPrestamo,
                    FechaDevolucion = p.FechaDevolucion,
                    TituloLibro = p.Libro != null ? p.Libro.Titulo : "Sin Libro",
                    AutorLibro = p.Libro != null && p.Libro.Autor != null ? p.Libro.Autor.Nombre : "Sin Autor"
                })
                .ToListAsync();

            return new DashboardViewModel
            {
                TotalLibros = totalLibros,
                TotalAutores = totalAutores,
                LibrosPrestados = librosPrestados,
                UltimosPrestamos = ultimosPrestamos
            };
        }
    }
}
