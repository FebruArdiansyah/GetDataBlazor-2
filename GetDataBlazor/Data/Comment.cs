﻿namespace GetDataBlazor.Data
{
    public class Comment
    {
        public int PostId { get; set; }
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Body { get; set; }
    }
}
