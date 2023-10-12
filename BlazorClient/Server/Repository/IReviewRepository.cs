using BlazorClient.Server.Dto;
using BlazorClient.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository
{
    public interface IReviewRepository
    {
        Task CreateReview(ReviewDto reviewDto);

    }
}