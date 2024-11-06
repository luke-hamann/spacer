using System;
using System.Collections.Generic;

namespace spacer.Models
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int id { get; set; }

        public string title { get; set; }

        public string content { get; set; }

        public DateTime creationDate { get; set; }

        public int forumId { get; set; }

        public Subspace Subspace { get; set; } = null!;

        public int userId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; }

    }
}
