using Microsoft.AspNetCore.Mvc;
using ProyectoUser.Models;
using ProyectoUser.Models.ViewModels;
using ProyectoUser.Services;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUser.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadosController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        // GET: Empleados
        public async Task<IActionResult> Index()
        {
            var empleados = await _empleadoService.GetAllAsync();
            var viewModel = empleados.Select(e => new EmpleadoViewModel
            {
                Id = e.Id,
                Nombre = e.Nombre,
                Apellido = e.Apellido,
                Email = e.Email,
                FechaContratacion = e.FechaContratacion,
                Salario = e.Salario
            });

            return View(viewModel);
        }

        // GET: Empleados/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var empleado = await _empleadoService.GetByIdAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            var viewModel = new EmpleadoViewModel
            {
                Id = empleado.Id,
                Nombre = empleado.Nombre,
                Apellido = empleado.Apellido,
                Email = empleado.Email,
                FechaContratacion = empleado.FechaContratacion,
                Salario = empleado.Salario
            };

            return View(viewModel);
        }

        // GET: Empleados/Create
        public IActionResult Create()
        {
            return View(new EmpleadoViewModel());
        }

        // POST: Empleados/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmpleadoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var empleado = new Empleado
                {
                    Nombre = viewModel.Nombre,
                    Apellido = viewModel.Apellido,
                    Email = viewModel.Email,
                    FechaContratacion = viewModel.FechaContratacion,
                    Salario = viewModel.Salario
                };

                await _empleadoService.AddAsync(empleado);
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // GET: Empleados/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var empleado = await _empleadoService.GetByIdAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            var viewModel = new EmpleadoViewModel
            {
                Id = empleado.Id,
                Nombre = empleado.Nombre,
                Apellido = empleado.Apellido,
                Email = empleado.Email,
                FechaContratacion = empleado.FechaContratacion,
                Salario = empleado.Salario
            };

            return View(viewModel);
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EmpleadoViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var empleado = new Empleado
                {
                    Id = viewModel.Id,
                    Nombre = viewModel.Nombre,
                    Apellido = viewModel.Apellido,
                    Email = viewModel.Email,
                    FechaContratacion = viewModel.FechaContratacion,
                    Salario = viewModel.Salario
                };

                await _empleadoService.UpdateAsync(empleado);
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        // GET: Empleados/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var empleado = await _empleadoService.GetByIdAsync(id);
            if (empleado == null)
            {
                return NotFound();
            }

            var viewModel = new EmpleadoViewModel
            {
                Id = empleado.Id,
                Nombre = empleado.Nombre,
                Apellido = empleado.Apellido,
                Email = empleado.Email,
                FechaContratacion = empleado.FechaContratacion,
                Salario = empleado.Salario
            };

            return View(viewModel);
        }

        // POST: Empleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _empleadoService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
