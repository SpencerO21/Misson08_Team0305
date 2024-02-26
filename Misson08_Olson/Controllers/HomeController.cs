using Microsoft.AspNetCore.Mvc;
using Misson08_Olson.Models;
using System.Diagnostics;

namespace Misson08_Olson.Controllers
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
            return View();
        }


    }
}
