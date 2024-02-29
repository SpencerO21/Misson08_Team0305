using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.categories = _repo.categories.ToList();
            return View("task");
        }

        [HttpPost]
        public IActionResult task(Task response)
        {

            if (ModelState.IsValid)
            {
                _repo.AddTask(response);

                return View("Index");
            }
            else
            {
                ViewBag.categories = _repo.categories.ToList();
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

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _repo.tasks.Single(x => x.TaskId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            _repo.RemoveTask(task);

            return RedirectToAction("Index");
        }


    }
}
