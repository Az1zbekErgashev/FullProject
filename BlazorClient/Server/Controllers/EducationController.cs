using BlazorClient.Server.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EducationController : Controller
{
    private readonly IEducationRepository _educationRepository;

    public EducationController(IEducationRepository educationRepository, ICourseRepository courseRepository)
    {
        _educationRepository = educationRepository;
    }
    [HttpGet("one")]
    public async Task<IActionResult> GetByid(int id)
    {
        var list = await _educationRepository.GetEducationById(id);
        return Ok(list);
    }

}


