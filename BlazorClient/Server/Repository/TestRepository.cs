using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly AppDbContext _context;
        public TestRepository(AppDbContext context) => _context = context;


        public async Task<List<Tests>> GetTestById(int id) => await _context.Tests.Include(u => u.Course).Where(i => i.Course.Id == id).ToListAsync();

    }
}
