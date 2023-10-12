using System.Diagnostics;
using BlazorClient.Server.Repository;
using BlazorClient.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClient.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactController : Controller
{
    private readonly IContactRepository _contactRepository;

    public ContactController(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }
    [HttpPost("one")]
    public async Task<ActionResult> GetAllTask(Contact contact)
    {

      
        await _contactRepository.CreateContactAsync(contact);
        return Ok();
    }
}
