using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class ApplicationUser : IdentityUser
    {


            public ICollection<TaskItem> TasksItems { get; set; } = new List<TaskItem>();
    }
}