﻿using BlazorClient.Server.Repository;
using BlazorClient.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;


namespace BlazorClient.Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactController : Controller
{
    private readonly IContactRepository _contactRepository;
    private readonly IMemoryCache _imemoryCache;
    public ContactController(IContactRepository contactRepository, IMemoryCache iMemoryCache)
    {
        _contactRepository = contactRepository;
        this._imemoryCache = iMemoryCache;
    }
    [HttpPost("one")]
    public async Task<ActionResult> GetAllTask(Contact contact)
    {
        await _contactRepository.CreateContactAsync(contact);

        var ContactPost = "ContactPost";
        if (!_imemoryCache.TryGetValue(ContactPost, out List<Contact> cachedContacts))
        {
            cachedContacts = await _contactRepository.GetContactAsync();

            _imemoryCache.Set("ContactPost", cachedContacts, TimeSpan.FromMinutes(30));

        }
        return Ok(cachedContacts);
    }
}
