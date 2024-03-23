using Microsoft.AspNetCore.Mvc;
using static LibroViewModel;

namespace Mvc.Controllers
{

public class LibrosController : Controller
{

    
    public List<LibroViewModel> librosList;

    public LibrosController()
    {
        librosList = new List<LibroViewModel>
        {
            new LibroViewModel
            {
                Nombre = "Don Quijote de la Mancha",
                Autor = "Miguel de Cervantes",
                Genero = "Novela de aventuras",
                Estado = EstadoLibro.Disponible,
                Isbn = "9788423349649",
                FechaPublicacion = "16/01/1605",
                NumeroCopias = 20
            },new LibroViewModel
            {
                Nombre = "Crónica de una muerte anunciada",
                Autor = "Gabriel García Márquez",
                Genero = "Novela",
                Estado = EstadoLibro.Disponible,
                Isbn = "9788437601513",
                FechaPublicacion = "01/10/1981",
                NumeroCopias = 7
            },
          new LibroViewModel
            {
                Nombre = "El alquimista",
                Autor = "Paulo Coelho",
                Genero = "Novela de desarrollo personal",
                Estado = EstadoLibro.Disponible,
                Isbn = "9780062511409",
                FechaPublicacion = "01/01/1988",
                NumeroCopias = 10
            },
          new LibroViewModel
            {
                Nombre = "Moby Dick",
                Autor = "Herman Melville",
                Genero = "Novela de aventuras",
                Estado = EstadoLibro.Disponible,
                Isbn = "9788491052163",
                FechaPublicacion = "18/10/1851",
                NumeroCopias = 9
            },
          new LibroViewModel
            {
                Nombre = "La metamorfosis",
                Autor = "Franz Kafka",
                Genero = "Ficción absurda",
                Estado = EstadoLibro.Disponible,
                Isbn = "9788491050251",
                FechaPublicacion = "1915",
                NumeroCopias = 6
            },
          new LibroViewModel
            {
                Nombre = "Harry Potter y la piedra filosofal",
                Autor = "J.K. Rowling",
                Genero = "Fantasía",
                Estado = EstadoLibro.Disponible,
                Isbn = "9788478884456",
                FechaPublicacion = "26/06/1997",
                NumeroCopias = 15
            },
          new LibroViewModel
            {
                Nombre = "1984",
                Autor = "George Orwell",
                Genero = "Ciencia ficción",
                Estado = EstadoLibro.Disponible,
                Isbn = "9788423342824",
                FechaPublicacion = "08/06/1949",
                NumeroCopias = 12
            },
          new LibroViewModel             
          {
                Nombre = "Orgullo y prejuicio",
                Autor = "Jane Austen",
                Genero = "Novela romántica",
                Estado = EstadoLibro.Disponible,
                Isbn = "9788491040276",
                FechaPublicacion = "28/01/1813",
                NumeroCopias = 5
            }
        };
    }

    public IActionResult Index()
    {
        ViewData["Title"] = "index";
        ViewData["listLibros"] = librosList;
        return View();
    }

      
        public bool RegistrarLibro(string nombre, string autor, string genero, EstadoLibro estadoActual, string isbn, string fechaPublicacion, int numeroCopias)
        {
          librosList.Add(new LibroViewModel
            {
                Nombre = nombre,
                Autor = autor,
                Genero = genero,
                Estado = estadoActual,
                Isbn = isbn,
                FechaPublicacion = fechaPublicacion,
                NumeroCopias = numeroCopias
            });

            return true;
        }

        public bool EditarEstadoActual(EstadoLibro nuevoEstado)
        {

            return true;
        }

        public bool EliminarLibro()
        {
            
            return true;
        }

        public bool EditarLibro(string nombre, string autor, string genero, EstadoLibro estadoActual, string isbn, string fechaPublicacion, int numeroCopias)
        {
            



            return true;
        }

        public ILibro BuscarLibroPorId(int id)
        {
          
            return null;
        }

        public ILibro[] MostrarLibros()
        {
         
            return null;
        }
    }

    public class Libro
    {
    }
}
