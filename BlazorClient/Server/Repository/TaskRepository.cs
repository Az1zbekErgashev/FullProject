using BlazorClient.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{

    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<Shared.Task>> GetAllTasks() => await _context.Task.ToListAsync();

        public async Task<Shared.Task> GetTasksById(int id)
        {
            var task = await _context.Task.FirstOrDefaultAsync(i => i.Id == id);
            return task;
        }
    }
}
