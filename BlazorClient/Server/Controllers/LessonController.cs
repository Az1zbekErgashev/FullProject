using BlazorClient.Server.Data;
using BlazorClient.Server.Repository;
using BlazorClient.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;
[Route("/api/[controller]")]
[ApiController]
public class LessonController : Controller
{
    private readonly ILessonsRepository _lessonsRepository;
    private readonly ICourseRepository _courseRepository;

    public LessonController(AppDbContext context, ILessonsRepository lessonsRepository, ICourseRepository courseRepository)
    {
        _lessonsRepository = lessonsRepository;
        _courseRepository = courseRepository;
    }
    [HttpGet("one")]
    public async Task<IActionResult> GetByid(int id)
    {
        var all = await _lessonsRepository.GetLessonsById(id);
        return Ok(all);
    }
}
