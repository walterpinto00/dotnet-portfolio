using System.ComponentModel.DataAnnotations;

namespace AplicacionRolesInventario.Models
{
    public class LoginViewModel
    {
        [Required] public string Usuario { get; set; }
        [Required, DataType(DataType.Password)] public string Contrasena { get; set; }
    }
}
