using BlazorClient.Server.Data;
using BlazorClient.Server.Dto;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository;
public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context) => _context = context;


    public async Task<List<Course>> GetCourseAllAsync()
    {
        return await _context.Course.ToListAsync();
    }
    public async Task<Course> GetEducation(int id)
    { 
        return await _context.Course.FirstOrDefaultAsync(u => u.Id == id) ?? throw new BadHttpRequestException("Course not found");
    }



}