using System.ComponentModel.DataAnnotations;

namespace AplicacionRolesInventario.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required, Display(Name = "Nombre del Producto")] public string Nombre { get; set; }
        [Required] public string Categoria { get; set; }
        [Range(0, 99999)] public int Stock { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; } = "Disponible";
    }
}
