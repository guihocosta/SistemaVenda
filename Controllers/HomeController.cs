using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SistemaVenda.DAL;
using SistemaVenda.Entidades;
using SistemaVenda.Models;

namespace SistemaVenda.Controllers
{
    public class HomeController : Controller
    {

        protected ApplicationDbContext Repositorio;

        public HomeController(ApplicationDbContext repositorio)
        {
            Repositorio = repositorio;

        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
