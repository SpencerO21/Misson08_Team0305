
namespace Misson08_Olson.Models
{
    public class EFTasksRepository : ITasksRepository
    {
        private TasksContext _context;
        public EFTasksRepository(TasksContext temp) {
            _context = temp;
        }
        public List<Task> tasks => _context.Tasks.ToList();
        public List<Category> categories => _context.Categories.ToList();

        public void AddTask(Task task)
        {
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
