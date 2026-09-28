using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApp.Services
{
    public class AutorService : IAutorService
    {
        private readonly ApplicationDbContext _context;

        public AutorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AutorIndexViewModel>> ObtenerTodosAsync(string? buscar)
        {
            var query = _context.Autores.AsQueryable();

            if (!string.IsNullOrWhiteSpace(buscar))
            {
                query = query.Where(a => a.Nombre.Contains(buscar));
            }

            // ✅ Mapeamos de Autor (modelo) a AutorIndexViewModel
            return await query.Select(a => new AutorIndexViewModel
            {
                Id = a.Id,
                Nombre = a.Nombre,
                Nacionalidad = a.Nacionalidad,
                FechaNacimiento = a.FechaNacimiento,
                TotalLibros = a.Libros.Count  // ← Dato calculado
            }).ToListAsync();
        }

        public async Task<AutorDetalleViewModel?> ObtenerDetalleAsync(int id)
        {
            var autor = await _context.Autores
                .Include(a => a.Libros)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (autor == null)
            {
                return null;
            }

            return new AutorDetalleViewModel
            {
                Id = autor.Id,
                Nombre = autor.Nombre,
                Nacionalidad = autor.Nacionalidad,
                FechaNacimiento = autor.FechaNacimiento,
                TotalLibros = autor.Libros.Count,
                TitulosLibros = autor.Libros.Select(l => l.Titulo).ToList()
            };
        }

        public async Task<CrearEditarAutorViewModel?> ObtenerViewModelParaEditarAsync(int id)
        {
            var autor = await _context.Autores.FindAsync(id);

            if (autor == null)
            {
                return null;
            }

            // Mapear del modelo al ViewModel
            return new CrearEditarAutorViewModel
            {
                Nombre = autor.Nombre,
                Nacionalidad = autor.Nacionalidad,
                FechaNacimiento = autor.FechaNacimiento
            };
        }

        public async Task<bool> ActualizarAutorAsync(int id, CrearEditarAutorViewModel viewModel)
        {
            var autor = await _context.Autores.FindAsync(id);

            if (autor == null)
            {
                return false;
            }

            // Actualizar solo las propiedades permitidas
            autor.Nombre = viewModel.Nombre;
            autor.Nacionalidad = viewModel.Nacionalidad;
            autor.FechaNacimiento = viewModel.FechaNacimiento.Value;

            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> CrearAutorAsync(CrearEditarAutorViewModel viewModel)
        {
            // Crear un nuevo objeto Autor a partir del ViewModel
            var autor = new Autor
            {
                Nombre = viewModel.Nombre,
                Nacionalidad = viewModel.Nacionalidad,
                FechaNacimiento = viewModel.FechaNacimiento.Value
            };

            // Agregarlo a la base de datos
            _context.Autores.Add(autor);

            // Guardar los cambios
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> EliminarAutorAsync(int id)
        {
            var autor = await _context.Autores.FindAsync(id);

            if (autor == null)
            {
                return false;
            }

            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
