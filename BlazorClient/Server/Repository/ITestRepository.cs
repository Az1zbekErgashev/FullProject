using BlazorClient.Server.Dto;
using BlazorClient.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository
{
    public interface ITestRepository
    {
        Task <List<Tests>> GetTestById(int id);
    }
}