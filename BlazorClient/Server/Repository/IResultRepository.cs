using BlazorClient.Server.Dto;
using BlazorClient.Shared;

namespace BlazorClient.Server.Repository;

public interface IResultRepository
{
    Task<List<Result>> GetAllResults(int id);
}
