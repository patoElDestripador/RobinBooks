using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class UsuarioController : Controller
    {

        //Views
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MostrarUsuario()
        {
            return View();
        }

        public IActionResult ValidarUsuario()
        {
            return View();
        }

        public IActionResult ActualizarUsuario()
        {
            return View();
        }

        public IActionResult RegistrarUsuario()
        {
            return View();
        }

    }
}