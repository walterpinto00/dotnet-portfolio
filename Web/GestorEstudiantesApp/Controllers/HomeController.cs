using GestorEstudiantesApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestorEstudiantesApp.Controllers
{
    public class HomeController : Controller
    {
        // Simulamos una lista en memoria para el ejemplo
        private static List<Estudiante> _estudiantes = new()
        {
            new Estudiante { Id = 1, Nombre = "Walter Pinto", Programa = "ADSO", Promedio = 9.5, Estado = "Activo", FechaIngreso = new DateTime(2026, 1, 15) },
            new Estudiante { Id = 2, Nombre = "Carlos Ramirez", Programa = "ADSO", Promedio = 8.7, Estado = "Activo", FechaIngreso = new DateTime(2026, 1, 15) }
        };

        public IActionResult Index()
        {
            return View(_estudiantes);
        }

        public IActionResult Crear() => View(new Estudiante());

        [HttpPost]
        public IActionResult Crear(Estudiante e)
        {
            if (!ModelState.IsValid) return View(e);
            e.Id = _estudiantes.Count + 1;
            _estudiantes.Add(e);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var e = _estudiantes.FirstOrDefault(x => x.Id == id);
            if (e == null) return NotFound();
            return View(e);
        }

        [HttpPost]
        public IActionResult Editar(Estudiante e)
        {
            var existing = _estudiantes.FirstOrDefault(x => x.Id == e.Id);
            if (existing == null) return NotFound();
            existing.Nombre = e.Nombre; existing.Programa = e.Programa;
            existing.Promedio = e.Promedio; existing.Estado = e.Estado;
            return RedirectToAction("Index");
        }

        public IActionResult Eliminar(int id)
        {
            var e = _estudiantes.FirstOrDefault(x => x.Id == id);
            if (e != null) _estudiantes.Remove(e);
            return RedirectToAction("Index");
        }
    }
}
