using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{
    public class EducationRepository : IEducationRepository
    {
        private readonly AppDbContext _context;
        private readonly AddData.AddData _add;
        public EducationRepository(AppDbContext context, AddData.AddData add)
        {
            _context = context;
            _add = add;
        }

        public async Task<Education> GetEducationById(int id)
        {
            List<Education> educations = await _add.GetEducationsAsyncList();


            var list = educations.FirstOrDefault(e => e.course.Id == id);
            return list;
        }


    }
}