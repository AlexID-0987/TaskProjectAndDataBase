using Microsoft.EntityFrameworkCore;

namespace emptyProject_task.Models
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }
        public DbSet<WeekTask> WeekTasks =>Set<WeekTask>();
    }
}
