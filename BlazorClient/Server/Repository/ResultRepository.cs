using BlazorClient.Server.Data;
using BlazorClient.Server.Repository;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Shared
{
    public class ResultRepository : IResultRepository
    {

        private readonly AppDbContext _context;
        public ResultRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Result>> GetAllResults(int id) => await _context.Result.Include(i => i.User).Include(i => i.Education).Where(f => f.Education.Id == id).ToListAsync();




    }
}
