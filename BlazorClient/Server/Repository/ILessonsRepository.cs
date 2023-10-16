using BlazorClient.Shared;

namespace BlazorClient.Server.Repository;

public interface ILessonsRepository
{
    Task<List<Lessons>> GetLessonsById(int id);

}
