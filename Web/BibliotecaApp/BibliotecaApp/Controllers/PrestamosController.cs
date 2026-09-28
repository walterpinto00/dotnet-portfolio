using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BibliotecaApp.Data;
using BibliotecaApp.Services;
using BibliotecaApp.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace BibliotecaApp.Controllers
{
    [Authorize(Roles = "Administrador,Bibliotecario")]
    public class PrestamosController : Controller
    {
        private readonly IPrestamoService _prestamoService;
        private readonly ApplicationDbContext _context; // Required only for SelectList of Libros in Create/Edit

        public PrestamosController(IPrestamoService prestamoService, ApplicationDbContext context)
        {
            _prestamoService = prestamoService;
            _context = context;
        }

        // GET: Prestamos
        public async Task<IActionResult> Index()
        {
            var prestamos = await _prestamoService.ObtenerTodosAsync();
            return View(prestamos);
        }

        // GET: Prestamos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var prestamo = await _prestamoService.ObtenerDetalleAsync(id.Value);

            if (prestamo == null) return NotFound();

            return View(prestamo);
        }

        // GET: Prestamos/Create
        public IActionResult Create()
        {
            ViewData["LibroId"] = new SelectList(_context.Libros, "Id", "Titulo");
            return View(new CrearEditarPrestamoViewModel());
        }

        // POST: Prestamos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CrearEditarPrestamoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var resultado = await _prestamoService.CrearPrestamoAsync(viewModel);
                if (resultado.Exito)
                {
                    return RedirectToAction(nameof(Index));
                }
                
                ModelState.AddModelError(string.Empty, resultado.MensajeError);
            }
            ViewData["LibroId"] = new SelectList(_context.Libros, "Id", "Titulo", viewModel.LibroId);
            return View(viewModel);
        }

        // GET: Prestamos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var viewModel = await _prestamoService.ObtenerViewModelParaEditarAsync(id.Value);
            if (viewModel == null) return NotFound();

            ViewData["LibroId"] = new SelectList(_context.Libros, "Id", "Titulo", viewModel.LibroId);
            return View(viewModel);
        }

        // POST: Prestamos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CrearEditarPrestamoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var exito = await _prestamoService.ActualizarPrestamoAsync(id, viewModel);
                if (!exito) return NotFound();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LibroId"] = new SelectList(_context.Libros, "Id", "Titulo", viewModel.LibroId);
            return View(viewModel);
        }

        // GET: Prestamos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var prestamo = await _prestamoService.ObtenerDetalleAsync(id.Value);
            if (prestamo == null) return NotFound();

            return View(prestamo);
        }

        // POST: Prestamos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exito = await _prestamoService.EliminarPrestamoAsync(id);
            if (!exito) return NotFound();
            return RedirectToAction(nameof(Index));
        }

        // POST: Prestamos/Devolver/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Devolver(int id)
        {
            var exito = await _prestamoService.DevolverLibroAsync(id);
            if (!exito) return NotFound();
            return RedirectToAction(nameof(Index));
        }
    }
}
