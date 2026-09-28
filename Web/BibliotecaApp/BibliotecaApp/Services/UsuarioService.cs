using BibliotecaApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsuarioService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<List<UsuarioViewModel>> ObtenerUsuariosAsync()
        {
            var usuarios = await _userManager.Users.ToListAsync();
            var lista = new List<UsuarioViewModel>();

            foreach (var user in usuarios)
            {
                var roles = await _userManager.GetRolesAsync(user);
                lista.Add(new UsuarioViewModel
                {
                    Id = user.Id,
                    Email = user.Email ?? "",
                    Rol = roles.FirstOrDefault() ?? "Sin Rol"
                });
            }

            return lista;
        }

        public async Task<bool> CrearUsuarioAsync(RegistroUsuarioViewModel model)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email, EmailConfirmed = true };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(model.Rol) && await _roleManager.RoleExistsAsync(model.Rol))
                {
                    await _userManager.AddToRoleAsync(user, model.Rol);
                }
                return true;
            }

            return false;
        }

        public async Task<bool> EliminarUsuarioAsync(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var result = await _userManager.DeleteAsync(user);
                return result.Succeeded;
            }
            return false;
        }

        public async Task<List<string>> ObtenerRolesDisponiblesAsync()
        {
            return await _roleManager.Roles.Select(r => r.Name!).ToListAsync();
        }
    }
}
