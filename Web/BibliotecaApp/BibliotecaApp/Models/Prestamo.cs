namespace BibliotecaApp.Models

{

    public class Prestamo

    {

        public int Id { get; set; }

        public string NombreUsuario { get; set; } = string.Empty;

        public DateTime FechaPrestamo { get; set; }

        public DateTime? FechaDevolucion { get; set; }

        public int LibroId { get; set; }

        public virtual Libro? Libro { get; set; }

    }

}