using Microsoft.EntityFrameworkCore;

namespace VehiculoApp.Datos
{
    public class VehiculoDbContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder o)
            => o.UseSqlServer(@"Server=.\SQLEXPRESS;Database=VehiculoDB;Trusted_Connection=True;");
    }
}
