using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public class PrestamoService : IPrestamoService
    {
        private readonly ApplicationDbContext _context;

        public PrestamoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PrestamoIndexViewModel>> ObtenerTodosAsync()
        {
            return await _context.Prestamos
                .Include(p => p.Libro)
                    .ThenInclude(l => l!.Autor)
                .Select(p => new PrestamoIndexViewModel
                {
                    Id = p.Id,
                    NombreUsuario = p.NombreUsuario,
                    FechaPrestamo = p.FechaPrestamo,
                    FechaDevolucion = p.FechaDevolucion,
                    TituloLibro = p.Libro != null ? p.Libro.Titulo : "Sin Libro",
                    AutorLibro = p.Libro != null && p.Libro.Autor != null ? p.Libro.Autor.Nombre : "Sin Autor",
                    DiasPrestado = p.FechaDevolucion.HasValue ? (p.FechaDevolucion.Value - p.FechaPrestamo).Days : (System.DateTime.Now - p.FechaPrestamo).Days,
                    EstadoLibro = p.FechaDevolucion.HasValue ? "Devuelto" : "Prestado"
                })
                .ToListAsync();
        }

        public async Task<PrestamoDetalleViewModel?> ObtenerDetalleAsync(int id)
        {
            var p = await _context.Prestamos
                .Include(p => p.Libro)
                    .ThenInclude(l => l!.Autor)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (p == null) return null;

            return new PrestamoDetalleViewModel
            {
                Id = p.Id,
                NombreUsuario = p.NombreUsuario,
                FechaPrestamo = p.FechaPrestamo,
                FechaDevolucion = p.FechaDevolucion,
                TituloLibro = p.Libro != null ? p.Libro.Titulo : "Sin Libro",
                AutorLibro = p.Libro != null && p.Libro.Autor != null ? p.Libro.Autor.Nombre : "Sin Autor"
            };
        }

        public async Task<CrearEditarPrestamoViewModel?> ObtenerViewModelParaEditarAsync(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null) return null;

            return new CrearEditarPrestamoViewModel
            {
                NombreUsuario = prestamo.NombreUsuario,
                FechaPrestamo = prestamo.FechaPrestamo,
                FechaDevolucion = prestamo.FechaDevolucion,
                LibroId = prestamo.LibroId
            };
        }

        public async Task<(bool Exito, string MensajeError)> CrearPrestamoAsync(CrearEditarPrestamoViewModel viewModel)
        {
            // Validar que el libro no esté prestado actualmente
            var libroPrestado = await _context.Prestamos
                .AnyAsync(p => p.LibroId == viewModel.LibroId && p.FechaDevolucion == null);

            if (libroPrestado)
            {
                return (false, "El libro seleccionado ya se encuentra prestado.");
            }

            var prestamo = new Prestamo
            {
                NombreUsuario = viewModel.NombreUsuario,
                FechaPrestamo = viewModel.FechaPrestamo,
                FechaDevolucion = viewModel.FechaDevolucion,
                LibroId = viewModel.LibroId
            };

            _context.Prestamos.Add(prestamo);
            await _context.SaveChangesAsync();
            return (true, string.Empty);
        }

        public async Task<bool> ActualizarPrestamoAsync(int id, CrearEditarPrestamoViewModel viewModel)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null) return false;

            prestamo.NombreUsuario = viewModel.NombreUsuario;
            prestamo.FechaPrestamo = viewModel.FechaPrestamo;
            prestamo.FechaDevolucion = viewModel.FechaDevolucion;
            prestamo.LibroId = viewModel.LibroId;

            _context.Prestamos.Update(prestamo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EliminarPrestamoAsync(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null) return false;

            _context.Prestamos.Remove(prestamo);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DevolverLibroAsync(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null || prestamo.FechaDevolucion != null) return false;

            prestamo.FechaDevolucion = System.DateTime.Now;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
