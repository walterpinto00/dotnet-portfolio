using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoUser.Models;

namespace ProyectoUser.Services
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<Empleado>> GetAllAsync();
        Task<Empleado?> GetByIdAsync(int id);
        Task AddAsync(Empleado empleado);
        Task UpdateAsync(Empleado empleado);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
