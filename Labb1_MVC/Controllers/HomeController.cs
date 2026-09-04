using Labb1_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboration1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine("I HomeController Index");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var errorView = new ErrorViewModel
            {
                Message = HttpContext.Items["Message"].ToString()
            };
            return View(errorView);
        }
    }
}
