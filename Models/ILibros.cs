        public interface ILibro
        {
            string Nombre { get; }
            string Autor { get; }
            string Genero { get; }
            EstadoLibro Estado { get; }
            string Isbn { get; }
            string FechaPublicacion { get; }
            int NumeroCopias { get; }
        }