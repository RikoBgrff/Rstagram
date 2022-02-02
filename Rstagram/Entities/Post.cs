using System;

namespace Rstagram.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int LikeCount { get; set; }
        public int UserId { get; set; }
        public DateTime PostDate { get; set; }
    }
}
