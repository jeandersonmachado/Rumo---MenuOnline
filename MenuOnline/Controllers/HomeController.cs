using MenuOnline.Models;
using MenuOnline.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace MenuOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPratoRepository _pratoRepository;

        public HomeController(IPratoRepository pratoRepository)
        {
            _pratoRepository = pratoRepository;
        }

        public IActionResult Index()
        {
            var lanches = _pratoRepository.Pratos;
            return View(lanches);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
