namespace emptyProject_task.Models
{
    public class EFTaskRepo : ITaskRepository
    {
        private TaskDbContext context;
        public EFTaskRepo(TaskDbContext con)
        {
            context = con;
        }
        public IQueryable<WeekTask> weekTasks=>context.WeekTasks;
    }
}
