using BlazorClient.Shared;

namespace BlazorClient.Server.Repository;

public interface ITeacherRepository
{
    Task<List<Teacher>> GetAllTeachers();
}
