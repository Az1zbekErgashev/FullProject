using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository;
public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _context;
    public CourseRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task<List<Course>> GetCourseAllAsync()
    {
        return await _context.Course.ToListAsync();
    }
    public async Task<Course> GetEducation(int id)
    {
        var list = await _context.Course.FirstOrDefaultAsync(i => i.Id == id) ?? throw new BadHttpRequestException("Course not found");
        return list;
    }




}