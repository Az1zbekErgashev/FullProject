using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorClient.Shared
{

    public class Tests
    {
        public int Id { get; set; }
        public string incorrect1 { get; set; }
        public string incorrect2 { get; set; }
        public string incorrect3 { get; set; }
        public string correct { get; set; }
        public string Queshioquestion { get; set; }
        public Course Course { get; set; }

    }
}
