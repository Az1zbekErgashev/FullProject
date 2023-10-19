using BlazorClient.Server.Repository;
using BlazorClient.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
      private readonly AddData.AddData _addData;
        public CourseController(ICourseRepository courseRepository, AddData.AddData addData)
        {
            _courseRepository = courseRepository;
            _addData = addData;
        }

        [HttpGet("coursall")]
        public async Task<IActionResult> GetCourse()
        {
              List<Course> courses = await _addData.GetCourseAsyncList();
            var all = await _courseRepository.GetCourseAllAsync();
            return Ok(courses);
        }


        [HttpGet("one")]
        public async Task<IActionResult> GetById(int id)
        {
            var alsdsl = await _courseRepository.GetEducation(id);
            return Ok(alsdsl);

        }
    }
}


