using BlazorClient.Server.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;
namespace BlazorClient.Server.Repository
{

    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;
        public TaskRepository(AppDbContext context) => _context = context;



        public async Task<List<Shared.Task>> GetAllTasks() => await _context.Task.Include(t=> t.Lessons).ToListAsync();

        public async Task<Shared.Task> GetTasksById(int id) => await _context.Task.Include(x => x.Lessons).FirstOrDefaultAsync(e => e.Id == id);
    }
}
