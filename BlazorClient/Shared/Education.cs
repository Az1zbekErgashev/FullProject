using System.Diagnostics.Contracts;

namespace BlazorClient.Shared
{
    public class Education
    {
        public int Id { get; set; }
        public Course? course { get; set; }
        public string? Tranding { get; set; }
        public List<string?> courseСompletion { get; set; }
        public string Description { get; set; }
        public string CourseEnd { get; set; }
    }
}
