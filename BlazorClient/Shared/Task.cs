using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorClient.Shared
{

    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Lessons Lessons { get; set; }
        public bool complete { get; set; }

        public string Data { get; set; }
    }
}
