using Microsoft.AspNetCore.Mvc;

namespace GestionTareas.Controllers
{
    public class ProductoController : Controller
    {
        // Acción para mostrar la lista principal
        public IActionResult Index()
        {
            return View();
        }

        // Acción para ver el detalle de un elemento
        public IActionResult Details()
        {
            return View();
        }

        // Acción para mostrar el formulario de creación
        public IActionResult Create()
        {
            return View();
        }

        // Acción para mostrar el formulario de edición
        public IActionResult Edit()
        {
            return View();
        }

        // Acción para eliminar un elemento
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
    }

}