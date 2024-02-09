using Microsoft.AspNetCore.Mvc;
using Mission5_Hawkins.Models;
using System.Diagnostics;

namespace Mission5_Hawkins.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //gives the view of the index page
        public IActionResult Index()
        {
            return View();
        }

        //gives the view of the calculator page
        public IActionResult Calculator()
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
