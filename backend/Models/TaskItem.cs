using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public required string TaskName { get; set; }

        public string? Description { get; set; }

        public DateOnly DueDate { get; set; }

        // User relationship
        //UserId is a string, not an integer,
        //  because IdentityUser uses a string for its ID.
        public string UserId { get; set; } = null!;

        public ApplicationUser? User { get; set; }

        // Category relationship
        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        // Task properties
        public TaskPriority Priority { get; set; }

        public TaskState Status { get; set; }
    }
}