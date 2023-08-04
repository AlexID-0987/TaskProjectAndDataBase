namespace emptyProject_task.Models
{
    public class WeekTask
    {
        public int? Id { get; set; }
        public string MyTask { get; set; } =String.Empty;
        public string WeekDay { get; set; } = String.Empty;
        public string Status { get; set;}=String.Empty;
        public string InfoTask { get; set; } = String.Empty;
    }
}
