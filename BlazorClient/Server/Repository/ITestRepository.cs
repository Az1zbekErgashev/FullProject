using BlazorClient.Shared;

namespace BlazorClient.Server.Repository
{
    public interface ITestRepository
    {
        Task<List<Tests>> GetTestById(int id);
    }
}