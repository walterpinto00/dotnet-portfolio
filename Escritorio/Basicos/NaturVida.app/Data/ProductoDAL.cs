using Microsoft.EntityFrameworkCore;
using NaturVida.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturVida.app.Data
{
    public class ProductoDAL
    {
        public List<Producto> ObtenerTodos()
        {
            using var db = new NaturVidaContext();
            // .Include() carga la categoría relacionada automáticamente
            return db.Productos.Include(p => p.Categoria)
                               .OrderBy(p => p.Nombre)
                               .ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            using var db = new NaturVidaContext();
            return db.Productos.Include(p => p.Categoria)
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
            var prod = db.Productos.Find(id);
            if (prod != null) { db.Productos.Remove(prod); db.SaveChanges(); }
        }
    }
}
