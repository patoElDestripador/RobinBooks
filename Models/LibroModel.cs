    public class LibroViewModel : ILibro{
            public string Nombre { get; set; }
            public string Autor { get; set; }
            public string Genero { get; set; }
            public EstadoLibro Estado { get; set; }
            public string Isbn { get; set; }
            public string FechaPublicacion { get; set; }
            public int NumeroCopias { get; set; }
    }
