using Natur.Vida.app.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Natur.Vida.app.Data;
public class CategoriaDAL
{
    public List<Categoria> ObtenerTodos()
    {
        using var db = new NaturVidaContext();
        return db.Categorias.OrderBy(c => c.Nombre).ToList();
    }
    public Categoria? ObtenerPorId(int id)
    {
        using var db = new NaturVidaContext();
        return db.Categorias.FirstOrDefault(c => c.Id == id);
    }
    public void Insertar(Categoria cat)
    {
        using var db = new NaturVidaContext();
        db.Categorias.Add(cat);
        db.SaveChanges();
    }
    public void Actualizar(Categoria cat)
    {
        using var db = new NaturVidaContext();
        db.Categorias.Update(cat);
        db.SaveChanges();
    }
    public void Eliminar(int id)
    {
        using var db = new NaturVidaContext();
        var cat = db.Categorias.Find(id); // Find carga la entidad para poder borrarla
        if (cat != null)
        {
            db.Categorias.Remove(cat);
            db.SaveChanges(); // Aquí se ejecuta el DELETE real
        }
    }
}
