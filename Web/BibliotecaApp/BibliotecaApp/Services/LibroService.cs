using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public class LibroService : ILibroService
    {
        private readonly ApplicationDbContext _context;

        public LibroService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PaginacionViewModel<LibroIndexViewModel>> ObtenerTodosAsync(string? estado = null, int pagina = 1, int tamanoPagina = 5)
        {
            var query = _context.Libros
                .Include(l => l.Autor)
                .Include(l => l.Prestamos)
                .AsQueryable();

            if (!string.IsNullOrEmpty(estado))
            {
                if (estado == "Prestados")
                {
                    query = query.Where(l => l.Prestamos.Any(p => p.FechaDevolucion == null));
                }
                else if (estado == "Disponibles")
                {
                    query = query.Where(l => !l.Prestamos.Any(p => p.FechaDevolucion == null));
                }
            }

            var totalElementos = await query.CountAsync();
            var totalPaginas = (int)System.Math.Ceiling(totalElementos / (double)tamanoPagina);

            var items = await query
                .Skip((pagina - 1) * tamanoPagina)
                .Take(tamanoPagina)
                .Select(l => new LibroIndexViewModel
                {
                    Id = l.Id,
                    Titulo = l.Titulo,
                    ISBN = l.ISBN,
                    AnioPublicacion = l.AnioPublicacion,
                    NombreAutor = l.Autor != null ? l.Autor.Nombre : "Sin Autor",
                    Estado = l.Prestamos.Any(p => p.FechaDevolucion == null) ? "Prestado" : "Disponible"
                }).ToListAsync();

            return new PaginacionViewModel<LibroIndexViewModel>
            {
                Items = items,
                PaginaActual = pagina,
                TotalPaginas = totalPaginas,
                TotalElementos = totalElementos
            };
        }

        public async Task<LibroDetalleViewModel?> ObtenerDetalleAsync(int id)
        {
            var libro = await _context.Libros
                .Include(l => l.Autor)
                .Include(l => l.Prestamos)
                .FirstOrDefaultAsync(l => l.Id == id);

            if (libro == null) return null;

            return new LibroDetalleViewModel
            {
                Id = libro.Id,
                Titulo = libro.Titulo,
                ISBN = libro.ISBN,
                AnioPublicacion = libro.AnioPublicacion,
                NombreAutor = libro.Autor != null ? libro.Autor.Nombre : "Sin Autor",
                NumeroPrestamos = libro.Prestamos.Count
            };
        }

        public async Task<CrearEditarLibroViewModel?> ObtenerViewModelParaEditarAsync(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro == null) return null;

            return new CrearEditarLibroViewModel
            {
                Titulo = libro.Titulo,
                ISBN = libro.ISBN,
                AnioPublicacion = libro.AnioPublicacion,
                AutorId = libro.AutorId
            };
        }

        public async Task<bool> CrearLibroAsync(CrearEditarLibroViewModel viewModel)
        {
            var libro = new Libro
            {
                Titulo = viewModel.Titulo,
                ISBN = viewModel.ISBN,
                AnioPublicacion = viewModel.AnioPublicacion,
                AutorId = viewModel.AutorId
            };

            _context.Libros.Add(libro);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ActualizarLibroAsync(int id, CrearEditarLibroViewModel viewModel)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro == null) return false;

            libro.Titulo = viewModel.Titulo;
            libro.ISBN = viewModel.ISBN;
            libro.AnioPublicacion = viewModel.AnioPublicacion;
            libro.AutorId = viewModel.AutorId;

            _context.Libros.Update(libro);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EliminarLibroAsync(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro == null) return false;

            _context.Libros.Remove(libro);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
