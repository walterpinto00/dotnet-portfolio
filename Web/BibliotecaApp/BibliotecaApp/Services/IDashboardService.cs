using BibliotecaApp.ViewModels;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public interface IDashboardService
    {
        Task<DashboardViewModel> ObtenerDashboardAsync();
    }
}
