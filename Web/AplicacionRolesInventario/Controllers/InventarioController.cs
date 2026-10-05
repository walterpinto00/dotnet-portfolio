using AplicacionRolesInventario.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionRolesInventario.Controllers
{
    public class InventarioController : Controller
    {
        private static List<Producto> _productos = new()
        {
            new Producto { Id = 1, Nombre = "Monitor LG 24 pulgadas", Categoria = "Electronica", Stock = 15, Precio = 800000m, Estado = "Disponible" },
            new Producto { Id = 2, Nombre = "Teclado Mecanico HyperX", Categoria = "Perifericos", Stock = 30, Precio = 250000m, Estado = "Disponible" },
            new Producto { Id = 3, Nombre = "Mouse Logitech G305", Categoria = "Perifericos", Stock = 0, Precio = 150000m, Estado = "Agotado" }
        };

        private bool IsAdmin() => HttpContext.Session.GetString("Rol") == "Admin";
        private bool IsLoggedIn() => HttpContext.Session.GetString("Usuario") != null;

        public IActionResult Index()
        {
            if (!IsLoggedIn()) return RedirectToAction("Login", "Account");
            return View(_productos);
        }

        public IActionResult Crear()
        {
            if (!IsAdmin()) return Forbid();
            return View(new Producto());
        }

        [HttpPost]
        public IActionResult Crear(Producto p)
        {
            if (!IsAdmin()) return Forbid();
            if (!ModelState.IsValid) return View(p);
            p.Id = _productos.Count + 1;
            _productos.Add(p);
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            if (!IsAdmin()) return Forbid();
            var p = _productos.FirstOrDefault(x => x.Id == id);
            if (p != null) _productos.Remove(p);
            return RedirectToAction("Index");
        }
    }
}
