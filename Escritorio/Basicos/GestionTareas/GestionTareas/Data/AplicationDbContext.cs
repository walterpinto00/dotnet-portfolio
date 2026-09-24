using GestionTareas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionTareas.Data
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
           { 

        
        }
        public DbSet<Tarea> Tareas { get; set; }
    }
}
