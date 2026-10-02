using System.ComponentModel.DataAnnotations;

namespace VehiculoApp.Datos
{
    public class Vehiculo
    {
        public int Id { get; set; }
        [Required] public string Placa { get; set; }
        [Required] public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal ValorComercial { get; set; }
    }
}
