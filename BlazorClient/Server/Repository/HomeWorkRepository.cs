using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository
{
    public class HomeWorkRepository : IHomeWorkRepository
    {
        private readonly AppDbContext _context;
        private readonly AddData.AddData _add;
        public HomeWorkRepository(AppDbContext context, AddData.AddData add)
        {
            _context = context;
            _add = add;
        }


        public async Task GetAllHomeWork()
        {
            await _context.Education.Include(i => i.course).ToListAsync();
        }

        public async Task<HomeWork> GetHomeWorkById(int id)
        {
            List<HomeWork> Home = await _add.GetHomeWork();
            var list = Home.FirstOrDefault(i => i.Id == id)!;
            return list;
        }

        public async Task<HomeWork> GetHomeWorkByRTaskId(int id)
            {
                return (await _context.HomeWork.Include(i => i.Task).FirstOrDefaultAsync(i => i.Task.Id == id))!;

            }
        }
    }
