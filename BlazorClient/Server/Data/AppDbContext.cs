using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<Shared.Task> Task { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<HomeWork> HomeWork { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Contact> Contact { get; set; }



    }
}
