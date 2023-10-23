using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository;

public class LessonRepository : ILessonsRepository
{
    private readonly AppDbContext _context;
    public LessonRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task<List<Lessons>> GetLessonsById(int id)
    {
        var list = await _context.Lessons.Include(i => i.Course).Where(i => i.Course.Id == id).ToListAsync();
        return list;
    }
}
