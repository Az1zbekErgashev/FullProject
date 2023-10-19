using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly AppDbContext _context;
        private readonly AddData.AddData _add;
        public TestRepository(AppDbContext context, AddData.AddData add)
        {
            _context = context;
            _add = add;
        }


        public async Task<List<Tests>> GetTestById(int id)
        {
            List<Tests> tests = await _add.GetTest();
            var list = tests.Where(i => i.Course.Id == id).ToList();
            return list;
        }

    }
}
