
using Microsoft.EntityFrameworkCore;

namespace Misson08_Olson.Models
{
    public class EFTasksRepository : ITasksRepository
    {
        private TasksContext _context;
        public EFTasksRepository(TasksContext temp) {
            _context = temp;
        }
        public List<Task> tasks => _context.Tasks.Include("Category").ToList();
        public List<Category> categories => _context.Categories.ToList();

        public void AddTask(Task task)
        {
            // Since auto gen numbers aren't working, here we do it manually
            var lastTask = _context.Tasks.OrderByDescending(t => t.TaskId).FirstOrDefault();
            task.TaskId = lastTask.TaskId + 1;
            _context.Add(task);
            _context.SaveChanges();
        }

        public void RemoveTask(Task task)
        {
            _context.Remove(task);
            _context.SaveChanges();
        }

        public void UpdateTask(Task task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }
    }
}
