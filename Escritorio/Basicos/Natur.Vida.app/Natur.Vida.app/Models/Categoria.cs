using System;
using System.Collections.Generic;
using System.Text;

namespace Natur.Vida.app.Models;
public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public bool Activo { get; set; }=true;
}
