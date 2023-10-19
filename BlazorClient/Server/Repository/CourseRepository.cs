using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository;
public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _context;
    private readonly AddData.AddData _add;
    public CourseRepository(AppDbContext context, AddData.AddData add)
    {
        _context = context;
        _add = add;
    }


    public async Task<List<Course>> GetCourseAllAsync()
    {
        return await _context.Course.ToListAsync();
    }
    public async Task<Course> GetEducation(int id)
    {
        List<Course> course = await _add.GetCourseAsyncList();
        return  course.FirstOrDefault(u => u.Id == id) ?? throw new BadHttpRequestException("Course not found");
    }




}