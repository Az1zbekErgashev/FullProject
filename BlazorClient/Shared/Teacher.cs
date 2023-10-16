using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorClient.Shared
{

    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

    }
}
