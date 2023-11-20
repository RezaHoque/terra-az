namespace ToDoApi.Models
{
    public class TodoItem
    {
        public string id { get; set; }
        public string title { get; set; }
        public bool isComplete { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string dueDate { get; set; }
        public string priority { get; set; }

    }
}
