﻿namespace BlazorClient.Shared
{
    public class Result
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public Education Education { get; set; }
        public User User { get; set; }
    }
}
