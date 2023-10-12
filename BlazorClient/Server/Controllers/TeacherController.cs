using BlazorClient.Server.Dto;
using BlazorClient.Server.Repository;
using BlazorClient.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TeacherController : Controller
{
    private readonly ITeacherRepository _teacherRepository;
    public TeacherController (ITeacherRepository teacherRepository) => _teacherRepository = teacherRepository;

    [HttpGet("one")]
    public async Task<IActionResult> GetReacher()
    {
        var list = await _teacherRepository.GetAllTeachers();
        return Ok( list);
    }
}
