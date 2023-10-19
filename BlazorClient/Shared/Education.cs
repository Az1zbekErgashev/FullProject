namespace BlazorClient.Shared
{

    public class Education
    {

        public int Id { get; set; }
        public Course? course { get; set; }
        public string courseComp1 { get; set; }
        public string courseComp2 { get; set; }
        public string courseComp3 { get; set; }
        public string courseComp4 { get; set; }
        public string? Tranding { get; set; }
        public string Description { get; set; }
        public string CourseEnd { get; set; }
    }
}
