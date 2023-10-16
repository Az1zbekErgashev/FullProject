using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorClient.Shared
{

    public class Lessons
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Video_url { get; set; }
        public string Description { get; set; }

        public Course Course { get; set; }

    }
}
