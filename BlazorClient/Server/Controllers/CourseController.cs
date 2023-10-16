using BlazorClient.Server.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetCourse()
        {
            var all = await _courseRepository.GetCourseAllAsync();
            return Ok(all);
        }


        [HttpGet("one")]
        public async Task<IActionResult> GetById(int id)
        {
            var alsdsl = await _courseRepository.GetEducation(id);
            return Ok(alsdsl);

        }
    }
}


