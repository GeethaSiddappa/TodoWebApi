namespace TodoApi.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }  // e.g., Pending, Completed
        public DateTime CreatedOn { get; set; }
        public DateTime DueDate { get; set; }
    }
}
