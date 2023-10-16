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

        public async Task<List<Feedback>> GetAllFeetback(int id) => await _context.Feedback.Include(e => e.Course).Include(i => i.User).Where(i => i.Course.Id == id).ToListAsync();
    }
}
