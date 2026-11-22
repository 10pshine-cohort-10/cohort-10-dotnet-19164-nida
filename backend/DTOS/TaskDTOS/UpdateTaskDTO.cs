using WebApplication1.Models.Enums;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;

namespace WebApplication1.DTOS.TaskDTOS
{
    public class UpdateTaskDTO
    {
        [Required]
        public String UserName { get; set; } = string.Empty;

        [Required]
        [StringLength (300, ErrorMessage = "Task name cannot exceed 300 characters.")]
        public string TaskName { get; set; } = string.Empty;
        [Required]
        [DueDate (ErrorMessage = "Due date must be between today and one year from today.")]
        public DateOnly DueDate { get; set; }

        [Required]
        [EnumDataType(typeof(TaskPriority), ErrorMessage = "Priority must be a Low, Medium or High value.")]
        public TaskPriority Priority { get; set; }
        [Required]
        public bool IsCompleted { get; set; }

    }
}