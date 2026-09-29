using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoUser.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RolesController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: Roles
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        // GET: Roles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                ModelState.AddModelError("", "El nombre del rol es obligatorio.");
                return View();
            }

            var roleExist = await _roleManager.RoleExistsAsync(roleName);
            if (roleExist)
            {
                ModelState.AddModelError("", "El rol ya existe.");
                return View();
            }

            await _roleManager.CreateAsync(new IdentityRole(roleName));
            TempData["Success"] = $"Rol '{roleName}' creado exitosamente.";
            return RedirectToAction(nameof(Index));
        }

        // GET: Roles/Edit/Admin
        public async Task<IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();
            return View(role);
        }

        // POST: Roles/Edit/Admin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                ModelState.AddModelError("", "El nombre del rol es obligatorio.");
                return View();
            }

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();

            role.Name = roleName;
            role.NormalizedName = roleName.ToUpper();

            await _roleManager.UpdateAsync(role);
            TempData["Success"] = $"Rol actualizado a '{roleName}' exitosamente.";
            return RedirectToAction(nameof(Index));
        }

        // GET: Roles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();
            return View(role);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
                TempData["Success"] = "Rol eliminado exitosamente.";
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Roles/AssignUsers/Admin
        public async Task<IActionResult> AssignUsers(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();

            var allUsers = await _userManager.Users.ToListAsync();
            var usersWithRole = new List<dynamic>();

            foreach (var user in allUsers)
            {
                var isInRole = await _userManager.IsInRoleAsync(user, role.Name);
                usersWithRole.Add(new
                {
                    User = user,
                    IsInRole = isInRole
                });
            }

            ViewBag.Role = role;
            return View(usersWithRole);
        }

        //cambiar roles a usuarios
        // POST: Roles/AssignUsers/Admin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignUsers(string id, string[] userIds)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null) return NotFound();

            var allUsers = await _userManager.Users.ToListAsync();

            foreach (var user in allUsers)
            {
                var isInRole = await _userManager.IsInRoleAsync(user, role.Name);
                var shouldHaveRole = userIds != null && userIds.Contains(user.Id);

                if (shouldHaveRole && !isInRole)
                {
                    await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!shouldHaveRole && isInRole)
                {
                    await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
            }

            TempData["Success"] = "Roles de usuarios actualizados exitosamente.";
            return RedirectToAction(nameof(AssignUsers), new { id });
        }
    }
}
