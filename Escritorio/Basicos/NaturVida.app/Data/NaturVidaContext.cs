using Microsoft.EntityFrameworkCore;
using NaturVida.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturVida.app.Data
{
    public class NaturVidaContext : DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NaturVidaDb;Integrated Security = true");
        }

        public DbSet<Producto> Productos { get; set; }
    }

    }
