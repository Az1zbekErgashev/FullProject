using BlazorClient.Shared;

namespace BlazorClient.Server.Data
{
    public class CourseSeed
    {
        public static void SeedAsync(BlazorClient.Server.Data.AppDbContext dbContext)
        {
            if (!dbContext.Course.Any())
            {
                var course = new Course
                {
                    Id = 1,
                    Description = "dasdasds",
                    Name = "dasdas",
                    Price = 23432432,
                    Url = "ukyjhgfdfgh"
                };

                dbContext.Course.AddRange(course);
                dbContext.SaveChanges();

            }
        }
    }
}
