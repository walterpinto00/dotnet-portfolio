using Natur.Vida.app.Data;
using Natur.Vida.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Natur.Vida.app.Logic;
public class ProductoBLL
{
    private readonly ProductoDAL dal = new();

    public List<Producto> Listar() => dal.ObtenerTodos();

    public string Guardar(Producto prod)
    {
        if (string.IsNullOrWhiteSpace(prod.Nombre))
            return "⚠️ El nombre es obligatorio.";

        if (prod.Nombre.Length > 50)
            return "⚠️ El nombre no puede exceder 50 caracteres.";

        if (prod.Precio <= 0)
            return "⚠️ El precio debe ser mayor a cero.";

        if (prod.CategoriaId <= 0)
            return "⚠️ Debes seleccionar una categoría.";

        try
        {
            if (prod.Id > 0) dal.Actualizar(prod);
            else dal.Insertar(prod);

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
