using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{
    public class EducationRepository : IEducationRepository
    {
        private readonly AppDbContext _context;
        public EducationRepository(AppDbContext context) => _context = context;

        public async Task<Education> GetEducationById(int id)
        {
            var list = await _context.Education.Include(i => i.course).FirstOrDefaultAsync(e => e.course.Id == id);
            return list;
        }
    }
}
