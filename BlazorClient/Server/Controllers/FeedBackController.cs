using BlazorClient.Server.Data;
using BlazorClient.Server.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class FeedBackController : Controller
{
    private readonly ICourseRepository _courseRepository;
    private readonly IUserRepository _userRepository;
    public readonly IFeedbackRepository _feedbackRepository;

    public FeedBackController(AppDbContext context, IFeedbackRepository feedbackRepository, ICourseRepository courseRepository, IUserRepository userRepository, AddData.AddData addData)
    {
        _feedbackRepository = feedbackRepository;
        _courseRepository = courseRepository;
        _userRepository = userRepository;
    }


    [HttpGet("one")]
    public async Task<IActionResult> GetFeedback(int id)
    {
        var all = await _feedbackRepository.GetAllFeetback(id);
        return Ok(all);
    }


}
