using AplicacionRolesInventario.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionRolesInventario.Controllers
{
    public class AccountController : Controller
    {
        private static readonly Dictionary<string, (string Password, string Rol)> _usuarios = new()
        {
            { "admin", ("admin123", "Admin") },
            { "usuario", ("user123", "Usuario") }
        };

        public IActionResult Login() => View(new LoginViewModel());

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            if (_usuarios.TryGetValue(model.Usuario.ToLower(), out var info) && info.Password == model.Contrasena)
            {
                HttpContext.Session.SetString("Usuario", model.Usuario);
                HttpContext.Session.SetString("Rol", info.Rol);
                return RedirectToAction("Index", "Inventario");
            }
            ModelState.AddModelError("", "Credenciales incorrectas.");
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
