namespace spacer.Models
{
    public class User
    {
        // Constructor to initialize both collections
        public User()
        {
            posts = new HashSet<Post>();
            comments = new HashSet<Comment>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public ICollection<Post> posts { get; set; }
        public ICollection<Comment> comments { get; set; }
    }
}
