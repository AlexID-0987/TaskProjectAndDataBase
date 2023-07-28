using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace emptyProject_task.Models
{
    public class TaskDbContext:DbContext
    {
        public DbSet<Task> Tasks { get; set;} //Dbset
        public TaskDbContext(DbContextOptions options) : base(options) { Database.EnsureCreated(); }
        

    }
}
