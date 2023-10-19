using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{
    public class FeedBackRepository : IFeedbackRepository
    {
        private AppDbContext _context;
        private readonly AddData.AddData _add;
        public FeedBackRepository(AppDbContext context, AddData.AddData add)
        {
            _context = context;
            _add = add;
        }

        public async Task<List<Feedback>> GetAllFeetback(int id)
        {
            List<Feedback> feedbacks = await _add.GetFeedback();
            var list = feedbacks.Where(i => i.Course.Id == id).ToList();
            return list;
                    
        }
    }
}
