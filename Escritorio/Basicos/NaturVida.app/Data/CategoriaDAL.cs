using NaturVida.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturVida.app.Data
{
    public class CategoriaDAL
    {
        public List<Categoria> ObtenerTodos()
        {
            using var db = new NaturVidaContext();
            return db.Categoria.OrderBy(c => c.Nombre).ToList();
        }

        public Categoria? ObtenerPorId(int id)
        {
            using var db = new NaturVidaContext();
            return db.Categoria.FirstOrDefault(c => c.Id == id);
        }
        public void Insertar(Categoria cat)
        {
            using var db = new NaturVidaContext();
            db.Categoria.Add(cat);
            db.SaveChanges();
        }
        public void Actualizar(Categoria cat)
        {
            using var db = new NaturVidaContext();
            db.Categoria.Update(cat);
            db.SaveChanges();
        }
        public void Eliminar(int id)
        {
            using var db = new NaturVidaContext();
            var cat = db.Categoria.Find(id); // Find carga la entidad para poder borrarla
            if (cat != null)
            {
                db.Categoria.Remove(cat);
                db.SaveChanges(); // Aquí se ejecuta el DELETE real
            }
        }
    }
}
