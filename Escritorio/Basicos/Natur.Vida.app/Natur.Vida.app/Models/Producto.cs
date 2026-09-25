using System;
using System.Collections.Generic;
using System.Text;

namespace Natur.Vida.app.Models;
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public decimal Precio { get; set; }
    public int Stock { get; set; }

    // 🔑 CLAVE FORÁNEA (Foreign Key)
    // EF Core reconoce automáticamente "NombreEntidadId"
    public int CategoriaId { get; set; }

    // 🧭 PROPIEDAD DE NAVEGACIÓN
    // Permite acceder al objeto Categoría completo desde un Producto
    public Categoria? Categoria { get; set; }
}
