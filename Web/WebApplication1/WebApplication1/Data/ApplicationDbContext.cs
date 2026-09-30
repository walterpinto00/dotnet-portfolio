using Microsoft.EntityFrameworkCore;

namespace GestionTareas.Data
{
    public class ApplicationDbContext : DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //tablas

    }
}