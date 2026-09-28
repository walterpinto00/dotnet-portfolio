using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BibliotecaApp.Data;
using BibliotecaApp.Models;
using BibliotecaApp.Services;
using BibliotecaApp.ViewModels;

using Microsoft.AspNetCore.Authorization;

namespace BibliotecaApp.Controllers
{
    [Authorize(Roles = "Administrador,Bibliotecario")]
    public class AutoresController : Controller
    {
        private readonly IAutorService _autorService;

        public AutoresController(IAutorService autorService)
        {
            _autorService = autorService;
        }

        // GET: Autores (REFACTORIZADO)
        public async Task<IActionResult> Index(string? buscar)
        {
            var autores = await _autorService.ObtenerTodosAsync(buscar);
            ViewBag.Buscar = buscar;
            return View(autores);
        }

        // GET: Autores/Details/5 (REFACTORIZADO)
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle = await _autorService.ObtenerDetalleAsync(id.Value);

            if (detalle == null)
            {
                return NotFound();
            }

            return View(detalle);
        }

        // GET: Autores/Create
        public IActionResult Create()
        {
            // Crear un ViewModel vacío
            var viewModel = new CrearEditarAutorViewModel();
            return View(viewModel);
        }

        // POST: Autores/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CrearEditarAutorViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            await _autorService.CrearAutorAsync(viewModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: Autores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = await _autorService
                .ObtenerViewModelParaEditarAsync(id.Value);

            if (viewModel == null)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // POST: Autores/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CrearEditarAutorViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var exito = await _autorService
                .ActualizarAutorAsync(id, viewModel);

            if (!exito)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Autores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalle = await _autorService.ObtenerDetalleAsync(id.Value);

            if (detalle == null)
            {
                return NotFound();
            }

            return View(detalle);
        }

        // POST: Autores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exito = await _autorService.EliminarAutorAsync(id);

            if (!exito)
            {
                return NotFound();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
