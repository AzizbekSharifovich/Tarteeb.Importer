﻿using System;

namespace Tarteeb.Importer.Models.Client;
public class Client
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTimeOffset BrithDate { get; set; }
    public Guid GroupId { get; set; }
}

