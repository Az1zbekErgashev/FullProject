using BlazorClient.Server.AddData;
using BlazorClient.Server.Data;
using BlazorClient.Server.Repository;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Shared
{
    public class ResultRepository : IResultRepository
    {

        private readonly AppDbContext _context;
        private readonly AddData _add;
        public ResultRepository(AppDbContext context, AddData add)
        {
            _context = context;
            _add = add;
        }

        public async Task<List<Result>> GetAllResults(int id)
        {
            List<Result> results = await _add.GetResult();
            var list = results.Where(i => i.Education.Id == id).ToList();
            return list;
        }

    }
}
