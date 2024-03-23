using Microsoft.AspNetCore.Mvc;


namespace Mvc.Controllers{
    public class LibrosController : Controller {
        public IActionResult Index() {
            ViewData["Title"] = "index";
            return View();
        }

    }
}

