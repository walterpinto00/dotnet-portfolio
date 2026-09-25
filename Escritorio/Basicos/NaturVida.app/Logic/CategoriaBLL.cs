using NaturVida.app.Data;
using NaturVida.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaturVida.app.Logic
{
    public class CategoriaBLL
    {
        private readonly CategoriaDAL dal = new();

        public List<Categoria> Listar() => dal.ObtenerTodos();

        public string Guardar(Categoria cat)
        {
            if (string.IsNullOrWhiteSpace(cat.Nombre))
                return "⚠️ El nombre es obligatorio.";

            if (cat.Nombre.Length > 50)
                return "⚠️ El nombre no puede exceder 50 caracteres.";

            try
            {
                if (cat.Id > 0) dal.Actualizar(cat);
                else dal.Insertar(cat);

                return "✅ Guardado correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error: " + ex.Message;
            }
        }

        public string Eliminar(int id)
        {
            try
            {
                dal.Eliminar(id);
                return "✅ Eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "❌ Error: " + ex.Message;
            }
        }
    }
}
