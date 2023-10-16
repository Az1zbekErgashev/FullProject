using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository
{
    public class HomeWorkRepository : IHomeWorkRepository
    {
        private readonly AppDbContext _context;
        public HomeWorkRepository(AppDbContext context) => _context = context;


        public async Task GetAllHomeWork()
        {
            await _context.Education.Include(i => i.course).ToListAsync();
        }

        public async Task<HomeWork> GetHomeWorkById(int id)
        {
            return (await _context.HomeWork.Include(i => i.Task).FirstOrDefaultAsync(i => i.Id == id))!;
        }

        public async Task<HomeWork> GetHomeWorkByRTaskId(int id)
        {
            return (await _context.HomeWork.Include(i => i.Task).FirstOrDefaultAsync(i => i.Task.Id == id))!;

        }
    }
}
