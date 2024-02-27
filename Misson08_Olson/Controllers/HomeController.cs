using Microsoft.AspNetCore.Mvc;
using Misson08_Olson.Models;
using System.Diagnostics;
using Task = Misson08_Olson.Models.Task;

namespace Misson08_Olson.Controllers
{
    public class HomeController : Controller
    {
        ITasksRepository _repo;

        public HomeController(ITasksRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult task()
        {
            return View("task", new Task());
        }

        [HttpPost]
        public IActionResult FIllOutApplication(Task response)
        {

            if (ModelState.IsValid)
            {
                _repo.AddTask(response);

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
            var recordToEdit = _repo.tasks
                .Single(x => x.TaskId == id);

            return View("task", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Task updatedInfo)
        {
            _repo.UpdateTask(updatedInfo);

            return RedirectToAction("Index");
        }




    }
}
