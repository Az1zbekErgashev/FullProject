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

        public async Task<List<Result>> GetAllResults(int id)
        {
            var list = await _context.Result.Include(i => i.User).Include(i => i.Education).Where(i => i.Education.Id == id).ToListAsync();
            return list;
        }

    }
}
