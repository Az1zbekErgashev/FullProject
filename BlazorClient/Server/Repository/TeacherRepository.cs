using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly AppDbContext _context;
        private readonly AddData.AddData _add;
        public TeacherRepository(AppDbContext context, AddData.AddData add)
        {
            _context = context;
            _add = add;
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            List<Teacher> teachers = await _add.GetTeacher();
            var list  = teachers.ToList();
            return list;
        }

    }
}
