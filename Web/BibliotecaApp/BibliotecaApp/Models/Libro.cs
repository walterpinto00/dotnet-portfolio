namespace BibliotecaApp.Models

{

    public class Libro

    {

        public int Id { get; set; }


        public string Titulo { get; set; } = string.Empty;


        public string ISBN { get; set; } = string.Empty;


        public int AnioPublicacion { get; set; }



        public int AutorId { get; set; }


        public virtual Autor? Autor { get; set; }

        public virtual ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

    }

}