using BlazorClient.Server.Dto;
using BlazorClient.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCourseAllAsync();
        Task<Course> GetEducation(int id);

    }
}