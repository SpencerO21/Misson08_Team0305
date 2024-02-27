namespace Misson08_Olson.Models
{
    public interface ITasksRepository
    {
        List<Task> tasks { get; }

        public void AddTask(Task task);
        public void RemoveTask(Task task);
        public void UpdateTask(Task task);
    }
}
