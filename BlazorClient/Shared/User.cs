﻿namespace BlazorClient.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public List<Course> Course { get; set; }


    }
}
