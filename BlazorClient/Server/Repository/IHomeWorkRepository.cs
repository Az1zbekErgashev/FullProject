using BlazorClient.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository
{
    public interface IHomeWorkRepository
    {
        Task GetAllHomeWork();
        Task<HomeWork> GetHomeWorkById(int id);
        Task<HomeWork> GetHomeWorkByRTaskId(int id);
    }
}