using BibliotecaApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public interface IUsuarioService
    {
        Task<List<UsuarioViewModel>> ObtenerUsuariosAsync();
        Task<bool> CrearUsuarioAsync(RegistroUsuarioViewModel model);
        Task<bool> EliminarUsuarioAsync(string id);
        Task<List<string>> ObtenerRolesDisponiblesAsync();
    }
}
