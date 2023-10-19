using BlazorClient.Server.Data;
using BlazorClient.Server.Repository;
using BlazorClient.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ResultController : Controller
{
    private readonly IResultRepository _resultRepository;
    private readonly IUserRepository _userRepository;
    private readonly IEducationRepository _educationRepository;
    private readonly AddData.AddData _add;
    public ResultController(AppDbContext context, IResultRepository resultRepository, IEducationRepository educationRepository, IUserRepository userRepository, AddData.AddData add)
    {
        _resultRepository = resultRepository;
        _educationRepository = educationRepository;
        _userRepository = userRepository;
        _add = add;
    }
    [HttpGet("one")]
    public async Task<IActionResult> GetResult(int id)
    {

        var all = await _resultRepository.GetAllResults(id);
        return Ok(all);
    }
}
