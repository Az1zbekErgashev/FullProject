using BlazorClient.Server.Data;
using Microsoft.EntityFrameworkCore;
using Task = BlazorClient.Shared.Task;

namespace BlazorClient.Server.Repository
{

    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;
        private readonly AddData.AddData _add;

        public TaskRepository(AppDbContext context, AddData.AddData add)
        {
            _context = context;
            _add = add;
        }


        public async Task<List<Shared.Task>> GetAllTasks()
        {
            List<Task> tasks = await _add.GetTask();
            var list = tasks.ToList();
            return list;
        }

        public async Task<Shared.Task> GetTasksById(int id)
        {
            List<Task> tasks = await _add.GetTask();
            var list = tasks.FirstOrDefault(i => i.Id == id);
            return list;
        }
    }
}
