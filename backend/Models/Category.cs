namespace WebApplication1.Models
{
    public class Category
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
            = new List<TaskItem>();
    }
}