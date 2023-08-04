
using emptyProject_task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;

namespace emptyProject_task.Controllers
{
    public class HomeController : Controller
    {
        private ITaskRepository repo;
        public HomeController (ITaskRepository taskRepository)
        {
            repo = taskRepository;
        }
       public IActionResult Index()=>View(repo.weekTasks);
        
       
    }
}
