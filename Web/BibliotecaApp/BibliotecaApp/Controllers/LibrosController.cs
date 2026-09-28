using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BibliotecaApp.Data;
using BibliotecaApp.Services;
using BibliotecaApp.ViewModels;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace BibliotecaApp.Controllers
{
    [Authorize]
    public class LibrosController : Controller
    {
        private readonly ILibroService _libroService;
        private readonly ApplicationDbContext _context; // Required only for SelectList of Authors in Create/Edit

        public LibrosController(ILibroService libroService, ApplicationDbContext context)
        {
            _libroService = libroService;
            _context = context;
        }

        // GET: Libros
        public async Task<IActionResult> Index(string? estado, int pagina = 1)
        {
            var viewModel = await _libroService.ObtenerTodosAsync(estado, pagina);
            ViewBag.Estado = estado;
            return View(viewModel);
        }

        // GET: Libros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var libro = await _libroService.ObtenerDetalleAsync(id.Value);

            if (libro == null) return NotFound();

            return View(libro);
        }

        // GET: Libros/Create
        [Authorize(Roles = "Administrador,Bibliotecario")]
        public IActionResult Create()
        {
            ViewData["AutorId"] = new SelectList(_context.Autores, "Id", "Nombre");
            return View(new CrearEditarLibroViewModel());
        }

        // POST: Libros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Bibliotecario")]
        public async Task<IActionResult> Create(CrearEditarLibroViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _libroService.CrearLibroAsync(viewModel);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_context.Autores, "Id", "Nombre", viewModel.AutorId);
            return View(viewModel);
        }

        // GET: Libros/Edit/5
        [Authorize(Roles = "Administrador,Bibliotecario")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var viewModel = await _libroService.ObtenerViewModelParaEditarAsync(id.Value);
            if (viewModel == null) return NotFound();

            ViewData["AutorId"] = new SelectList(_context.Autores, "Id", "Nombre", viewModel.AutorId);
            return View(viewModel);
        }

        // POST: Libros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Bibliotecario")]
        public async Task<IActionResult> Edit(int id, CrearEditarLibroViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var exito = await _libroService.ActualizarLibroAsync(id, viewModel);
                if (!exito) return NotFound();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AutorId"] = new SelectList(_context.Autores, "Id", "Nombre", viewModel.AutorId);
            return View(viewModel);
        }

        // GET: Libros/Delete/5
        [Authorize(Roles = "Administrador,Bibliotecario")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var libro = await _libroService.ObtenerDetalleAsync(id.Value);
            if (libro == null) return NotFound();

            return View(libro);
        }

        // POST: Libros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrador,Bibliotecario")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exito = await _libroService.EliminarLibroAsync(id);
            if (!exito) return NotFound();
            return RedirectToAction(nameof(Index));
        }
    }
}
