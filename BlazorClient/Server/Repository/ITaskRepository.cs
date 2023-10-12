using Task = BlazorClient.Shared.Task;

namespace BlazorClient.Server.Repository;

public interface ITaskRepository
{
    Task<List<Shared.Task>> GetAllTasks();
    Task<Task> GetTasksById(int id);
}
