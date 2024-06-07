using Microsoft.AspNetCore.Mvc;

namespace MenuOnline.Controllers
{
    public class CozinhaController : Controller
    {
        public IActionResult Prato()
        {
            return View();
        }
    }
}
