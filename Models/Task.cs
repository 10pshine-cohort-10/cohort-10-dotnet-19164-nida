namespace WebApplication1.Models
{
    public class Task
    {
        public int Id { get; set; }

        public required string TaskName { get; set; } 

        public  required string UserName { get; set; }
        public required string Category { get; set; }
        public required DateOnly DueDate { get; set; }
        public required int Priority { get; set; }
        public bool IsCompleted { get; set; }
    }
}