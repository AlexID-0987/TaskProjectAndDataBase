using Microsoft.EntityFrameworkCore;

namespace emptyProject_task.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            TaskDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TaskDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.WeekTasks.Any())
            {
                context.WeekTasks.AddRange(
                    new WeekTask
                    {
                      MyTask="Learn", WeekDay="Friday", Status="Warning", InfoTask="C#"
                    }
                    );
                context.SaveChanges();
            }
        } 
    }
}
