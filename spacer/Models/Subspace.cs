namespace spacer.Models
{
    public class Subspace
    {
        public Subspace() => posts = new HashSet<Post>();

        public int id { get; set; }
        public string name { get; set; }



        //Relationships
        public ICollection<Post> posts { get; set; }

    }
}
