using BlazorClient.Server.Data;
using BlazorClient.Server.Dto;
using BlazorClient.Shared;
using Task = System.Threading.Tasks.Task;


namespace BlazorClient.Server.Repository;

public class ReviewRepository : IReviewRepository
{
    private readonly AppDbContext _context;
    public ReviewRepository(AppDbContext context) { _context = context; }
    public async Task CreateReview(ReviewDto reviewDto)
    {
        Review review = new Review();
        review.Course_info = review.Course_info;
        review.Course_name = review.Course_name;
        review.comment = review.comment;
        review.Task = review.Task;
        _context.Review.Add(review);
        await _context.SaveChangesAsync();
    }

}
