using BibliotecaApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public interface ILibroService
    {
        Task<PaginacionViewModel<LibroIndexViewModel>> ObtenerTodosAsync(string? estado = null, int pagina = 1, int tamanoPagina = 5);
        Task<LibroDetalleViewModel?> ObtenerDetalleAsync(int id);
        Task<CrearEditarLibroViewModel?> ObtenerViewModelParaEditarAsync(int id);
        Task<bool> CrearLibroAsync(CrearEditarLibroViewModel viewModel);
        Task<bool> ActualizarLibroAsync(int id, CrearEditarLibroViewModel viewModel);
        Task<bool> EliminarLibroAsync(int id);
    }
}
