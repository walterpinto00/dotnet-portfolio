namespace BibliotecaApp.ViewModels
{
    public class AutorIndexViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nacionalidad { get; set; } = string.Empty;
        public DateTime? FechaNacimiento { get; set; }
        public int TotalLibros { get; set; }  // ← ¡Dato extra!
    }
}
