using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;
using Task = BlazorClient.Shared.Task;

namespace BlazorClient.Server.Data;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>();
        modelBuilder.Entity<User>();
        modelBuilder.Entity<Teacher>();
        modelBuilder.Entity<HomeWork>();
        modelBuilder.Entity<Task>();
        modelBuilder.Entity<Lessons>();
        modelBuilder.Entity<Feedback>();
        modelBuilder.Entity<Result>();
        modelBuilder.Entity<Review>();
        modelBuilder.Entity<Tests>();
        modelBuilder.Entity<Contact>();
        base.OnModelCreating(modelBuilder);

    }
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