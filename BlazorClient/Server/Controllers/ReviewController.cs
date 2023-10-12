using BlazorClient.Server.Dto;
using BlazorClient.Server.Repository;
using BlazorClient.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;

public class ReviewController : Controller
{
    private readonly IReviewRepository _reviewRepository;
    private readonly ITaskRepository _taskRepository;
    public ReviewController( IReviewRepository reviewRepository, ITaskRepository taskRepository)
    {
        _reviewRepository = reviewRepository;
        _taskRepository = taskRepository;
    }

    public async Task<IActionResult> AddReview(ReviewDto addReview)
    {
        await _reviewRepository.CreateReview(addReview);
        return Ok();
    }
}
