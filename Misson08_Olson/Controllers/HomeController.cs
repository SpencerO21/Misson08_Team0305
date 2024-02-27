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

        [HttpGet]
        public IActionResult task()
        {
            return View("task", new task());
        }

        [HttpPost]
        public IActionResult FIllOutApplication(task response)
        {
            if (response.Date == null) { response.Date = ""; }

            if (ModelState.IsValid)
            {
                _logger.Tasks.Add(response); // Add record to the database
                _logger.SaveChanges();

                return View("Index", response);
            }
            else
            {
                return View("task", response);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _logger.Tasks
                .Single(x => x.TaskId == id);

            return View("task", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(task updatedInfo)
        {
            _logger.Update(updatedInfo);
            _logger.SaveChanges();

            return RedirectToAction("Index");
        }




    }
}
