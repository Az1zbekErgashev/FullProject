using BlazorClient.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository;

public interface IContactRepository
{
   Task CreateContactAsync(Contact contact);
}
