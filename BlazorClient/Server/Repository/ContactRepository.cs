using BlazorClient.Server.Data;
using BlazorClient.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Server.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _context;
        public ContactRepository(AppDbContext context) => _context = context;

        public async Task<List<Contact>> GetContactAsync() => await _context.Contact.ToListAsync();

        public async System.Threading.Tasks.Task CreateContactAsync(Contact contact)
        {
            await _context.Contact.AddAsync(contact);
            await _context.SaveChangesAsync();
        }
    }

}