using System.ComponentModel.DataAnnotations;

namespace FarmaciaApp
{
    public class Medicamento
    {
        public int Id { get; set; }
        [Required] public string Nombre { get; set; }
        [Required] public string Laboratorio { get; set; }
        public string Presentacion { get; set; }
        public int Stock { get; set; }
        public decimal PrecioUnitario { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
