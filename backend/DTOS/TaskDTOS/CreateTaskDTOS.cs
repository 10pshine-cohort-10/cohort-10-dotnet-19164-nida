using WebApplication1.Models.Enums;
 using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;


namespace WebApplication1.DTOS.TaskDTOS
{
    public class CreateTaskDTO
    {
        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [StringLength(300, ErrorMessage = "Task name cannot exceed 300 characters.")]
        public string TaskName { get; set; } = string.Empty;
        [Required]
        [DueDate(ErrorMessage = "Due date must be between today and one year from today.")]
        public DateOnly DueDate { get; set; }

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        [EnumDataType(typeof(TaskPriority),
            ErrorMessage = "Priority must be Low, Medium or High.")]
        public TaskPriority? Priority { get; set; }

        public bool IsCompleted { get; set; }
    }
}