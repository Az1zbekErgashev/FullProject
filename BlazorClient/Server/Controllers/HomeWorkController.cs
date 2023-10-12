using BlazorClient.Server.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;

public class HomeWorkController : Controller
{
    private readonly ITaskRepository _taskRepository;
    private readonly IHomeWorkRepository _homeWorkRepository;

    public HomeWorkController(IHomeWorkRepository homeWorkRepository, ITaskRepository taskRepository)
    {
        _homeWorkRepository = homeWorkRepository;
        _taskRepository = taskRepository;
    }
    [HttpGet]

    public async Task<IActionResult> GetById(int id)
    {

        var alsdsl = await _homeWorkRepository.GetHomeWorkById(id);
        return Ok(alsdsl);

    }
}
