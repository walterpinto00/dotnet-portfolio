using Microsoft.EntityFrameworkCore;
using Natur.Vida.app.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Natur.Vida.app.Data;
public class ProductoDAL
{
    public List<Producto> ObtenerTodos()
    {
        using var db = new NaturVidaContext();
        return db.Productos
            .Include(p => p.Categoria)
            .OrderBy(p => p.Nombre)
            .ToList();
    }

    public Producto? ObtenerPorId(int id)
    {
        using var db = new NaturVidaContext();
        return db.Productos
            .Include(p => p.Categoria)
            .FirstOrDefault(p => p.Id == id);
    }

    public void Insertar(Producto prod)
    {
        using var db = new NaturVidaContext();
        db.Productos.Add(prod);
        db.SaveChanges();
    }

    public void Actualizar(Producto prod)
    {
        using var db = new NaturVidaContext();
        db.Productos.Update(prod);
        db.SaveChanges();
    }

    public void Eliminar(int id)
    {
        using var db = new NaturVidaContext();
        var prod = db.Productos.Find(id); // Find carga la entidad para poder borrarla
        if (prod != null)
        {
            db.Productos.Remove(prod);
            db.SaveChanges(); // Aquí se ejecuta el DELETE real
        }
    }
}
