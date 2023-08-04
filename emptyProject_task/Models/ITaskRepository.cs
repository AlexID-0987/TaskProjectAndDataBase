namespace emptyProject_task.Models
{
    public interface ITaskRepository
    {
        IQueryable<WeekTask> weekTasks { get; }
    }
}
