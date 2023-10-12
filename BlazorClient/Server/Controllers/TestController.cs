using BlazorClient.Server.Data;
using BlazorClient.Server.Repository;
using BlazorClient.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;
[Route("/api/[controller]")]
[ApiController]
public class TestController : Controller
{
    private readonly ITestRepository _testRepository;
    private readonly ICourseRepository _courseRepository;
    public TestController(AppDbContext context, ITestRepository testRepository, ICourseRepository courseRepository)
    {
        _testRepository = testRepository;
        _courseRepository = courseRepository;
    }

    [HttpGet("one")]
    public async Task<IActionResult> GetById(int id)
    {
        var all = await _testRepository.GetTestById(id);
        return Ok(all);
    }
}
