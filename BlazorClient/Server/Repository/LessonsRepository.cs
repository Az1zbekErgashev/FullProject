using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository;

public class LessonRepository : ILessonsRepository
{
    private readonly AppDbContext _context;
    private readonly AddData.AddData _add;
    public LessonRepository(AppDbContext context, AddData.AddData add)
    {
        _context = context;
        _add = add;
    }


    public async Task<List<Lessons>> GetLessonsById(int id)
    {
        List<Lessons> lessonsList = await _add.GetLesson();
        var list = lessonsList.Where(i => i.Course.Id == id).ToList();
        return list;
    }
}
