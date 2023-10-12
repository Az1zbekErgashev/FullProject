using BlazorClient.Server.Data;
using BlazorClient.Server.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;
[Route("/api/[controller]")]
[ApiController]
public class TaskController : Controller
{
    private readonly ITaskRepository _taskRepository;
    private readonly ILessonsRepository _lessonsRepository;

    public TaskController(AppDbContext context, ITaskRepository taskRepository, ILessonsRepository lessonsRepository)
    {
        _taskRepository = taskRepository;
        _lessonsRepository = lessonsRepository;
    }
    [HttpGet("one")]
    public async Task<IActionResult> GetTask()
    {
        var all = await _taskRepository.GetAllTasks();
        return Ok(all);
    }
    [HttpGet("two")]

    public async Task<IActionResult> GetById(int id)
    {
        var all = await _taskRepository.GetTasksById(id);
        return Ok(all);
    }


}
