using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{
    public class FeedBackRepository : IFeedbackRepository
    {
        private AppDbContext _context;
        public FeedBackRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Feedback>> GetAllFeetback(int id)
        {
            var list = await _context.Feedback.Include(i => i.Course.Id).Where(i => i.Course.Id == id).ToListAsync();
            return list;

        }
    }
}
