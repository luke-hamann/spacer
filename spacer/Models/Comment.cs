using System;
using System.Globalization;

namespace spacer.Models
{

    public class Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public DateTime creationDate { get; set; }

        // Relationships

        public int userId { get; set; }
        public User? User { get; set; } = null!;

        public int postId { get; set; }
        public Post? Post { get; set; } = null!;

    }
}
