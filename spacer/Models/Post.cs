using System.Text.RegularExpressions;

namespace spacer.Models
{
    public class Post
    {
        public Post()
        {
            comments = new HashSet<Comment>();
        }

        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public DateTime creationDate { get; set; }

        public int forumId { get; set; }
        public Subspace? subspace { get; set; } = null;

        public int userId { get; set; }
        public User? user { get; set; } = null;

        public ICollection<Comment> comments { get; set; }

        public string slug => Regex.Replace(title.Trim().ToLower(), "[^\\w-]", "-");
    }
}
