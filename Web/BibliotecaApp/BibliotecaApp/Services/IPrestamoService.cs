using BibliotecaApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public interface IPrestamoService
    {
        Task<IEnumerable<PrestamoIndexViewModel>> ObtenerTodosAsync();
        Task<PrestamoDetalleViewModel?> ObtenerDetalleAsync(int id);
        Task<CrearEditarPrestamoViewModel?> ObtenerViewModelParaEditarAsync(int id);
        Task<(bool Exito, string MensajeError)> CrearPrestamoAsync(CrearEditarPrestamoViewModel viewModel);
        Task<bool> ActualizarPrestamoAsync(int id, CrearEditarPrestamoViewModel viewModel);
        Task<bool> EliminarPrestamoAsync(int id);
        Task<bool> DevolverLibroAsync(int id);
    }
}
