namespace Misson08_Olson.Models
{
    public interface ITasksRepository
    {
        List<Task> tasks { get; }
        List<Category> categories { get; }

        public void AddTask(Task task);
        public void RemoveTask(Task task);
        public void UpdateTask(Task task);
    }
}
