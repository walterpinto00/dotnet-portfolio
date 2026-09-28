using BibliotecaApp.ViewModels;

namespace BibliotecaApp.Services
{
    public interface IAutorService
    {
        Task<IEnumerable<AutorIndexViewModel>> ObtenerTodosAsync(string? buscar);

        Task<AutorDetalleViewModel?> ObtenerDetalleAsync(int id);

        Task<CrearEditarAutorViewModel?> ObtenerViewModelParaEditarAsync(int id);
        Task<bool> ActualizarAutorAsync(int id, CrearEditarAutorViewModel viewModel);

        Task<bool> CrearAutorAsync(CrearEditarAutorViewModel viewModel);

        Task<bool> EliminarAutorAsync(int id);
    }
}
