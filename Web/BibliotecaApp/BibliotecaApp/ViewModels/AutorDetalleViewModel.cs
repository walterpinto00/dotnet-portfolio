namespace BibliotecaApp.ViewModels
{
    public class AutorDetalleViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;
        public DateTime? FechaNacimiento { get; set; }
        public int TotalLibros { get; set; }
        public List<string> TitulosLibros { get; set; } = new List<string>();
    }
}
