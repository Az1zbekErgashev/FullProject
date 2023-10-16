using BlazorClient.Shared;

namespace BlazorClient.Server.Repository
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetCourseAllAsync();
        Task<Course> GetEducation(int id);

    }
}