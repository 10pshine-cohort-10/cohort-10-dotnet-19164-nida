using WebApplication1.Models.Enums;

namespace WebApplication1.DTOS.TaskDTOS
{
    public record class TaskDTO
    {
        public int Id { get; set; }

        public string TaskName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public DateOnly DueDate { get; set; }

        public TaskPriority Priority { get; set; }

        public bool IsCompleted { get; set; }
    }
}