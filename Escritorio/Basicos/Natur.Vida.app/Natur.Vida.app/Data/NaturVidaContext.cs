using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Natur.Vida.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natur.Vida.app.Data;
public class NaturVidaContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NaturVidaDB;Trusted_Connection=true;");
    }
}
