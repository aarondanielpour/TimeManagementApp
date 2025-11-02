using System.ComponentModel.DataAnnotations;
namespace TimeManagementApp.Models
{
    public enum PriorityLevel
    {
        High, Medium, Low
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public PriorityLevel Priority { get; set; } // 1=High, 2=Medium, 3=Low
    }
}
