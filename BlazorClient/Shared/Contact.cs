﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorClient.Shared;

public class Contact
{

    public int Id { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Location { get; set; }
}