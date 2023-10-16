using BlazorClient.Shared;
using Task = System.Threading.Tasks.Task;

namespace BlazorClient.Server.Repository;

public interface IContactRepository
{
    Task<List<Contact>> GetContactAsync();
    Task CreateContactAsync(Contact contact);
}
