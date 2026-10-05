using Microsoft.EntityFrameworkCore;

namespace FarmaciaApp
{
    public class FarmaciaDbContext : DbContext
    {
        public DbSet<Medicamento> Medicamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
            => opt.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FarmaciaDB;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder m)
        {
            m.Entity<Medicamento>().HasData(
                new Medicamento { Id = 1, Nombre = "Ibuprofeno 400mg", Laboratorio = "Genfar", Presentacion = "Tableta", Stock = 100, PrecioUnitario = 850m, FechaVencimiento = new DateTime(2026, 12, 31) },
                new Medicamento { Id = 2, Nombre = "Amoxicilina 500mg", Laboratorio = "La Sante", Presentacion = "Capsula", Stock = 60, PrecioUnitario = 1200m, FechaVencimiento = new DateTime(2025, 8, 15) }
            );
        }
    }
}
