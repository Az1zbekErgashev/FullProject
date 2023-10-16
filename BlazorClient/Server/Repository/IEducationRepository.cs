using BlazorClient.Shared;

namespace BlazorClient.Server.Repository;

public interface IEducationRepository
{

    Task<Education> GetEducationById(int id);
}
