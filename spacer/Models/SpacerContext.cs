using Microsoft.EntityFrameworkCore;
using System;

namespace spacer.Models
{
    public class SpacerContext : DbContext
    {
        public SpacerContext(DbContextOptions<SpacerContext> options) : base(options)
        { }

        public DbSet<Subspace> Subspaces { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        public DbSet<Comment> Comments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationships
            modelBuilder.Entity<Subspace>()
                  .HasMany(s => s.posts)
                  .WithOne(p => p.Subspace)
                  .HasForeignKey(p => p.forumId) 
                  .OnDelete(DeleteBehavior.Cascade); // Cascade delete on Subspace

            modelBuilder.Entity<User>()
                .HasMany(u => u.posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.userId) 
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete on User

            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.userId) 
                .OnDelete(DeleteBehavior.Cascade); // Cascade delete on User

            modelBuilder.Entity<Post>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.postId) 
                .OnDelete(DeleteBehavior.Restrict);



            //Seed Data
            modelBuilder.Entity<Subspace>().HasData(
                new Subspace { id = 1, name = "technology" },
                new Subspace { id = 2, name = "science" },
                new Subspace { id = 3, name = "gaming" },
                new Subspace { id = 4, name = "music" }
                );
            modelBuilder.Entity<User>().HasData(
                new User { id = 1, name = "alice", email = "alice@example.com", password = "password1" },
                new User { id = 2, name = "bob", email = "bob@example.com", password = "password2" },
                new User { id = 3, name = "charlie", email = "charlie@example.com", password = "password3" },
                new User { id = 4, name = "dave", email = "dave@example.com", password = "password4" }

                );
            // Seed Posts and Comments
            string[] postTitles = new[]
            {
                "Tech Innovations", "Space Discoveries", "Game Releases", "Music Trends",
                "AI in 2024", "Mars Rover", "New Console", "Top 10 Albums",
                "Gadgets 2023", "Climate Change", "Indie Games", "Concerts Near Me",
                "Future of Tech", "Quantum Physics", "VR Experience", "Live Performances"
            };

            string[] commentContents = new[]
            {
                "Great article!", "Very interesting!", "Loved this!", "I agree!",
                "Nice perspective!", "More details please!", "Can you elaborate?", "Interesting read!",
                "Fascinating stuff!", "Totally true!", "Can't wait!", "So true!",
                "Well said!", "Looking forward!", "Absolutely!", "Keep it up!"
            };

            int postIndex = 0;
            for (int subspaceId = 1; subspaceId <= 4; subspaceId++)
            {
                for (int postId = 1; postId <= 4; postId++)
                {
                    // Create Post
                    modelBuilder.Entity<Post>().HasData(new Post
                    {
                        id = (subspaceId - 1) * 4 + postId, // Unique Post ID
                        title = postTitles[postIndex++ % postTitles.Length], // Cycle through post titles
                        content = "Post content", // Generic content since titles are different
                        creationDate = DateTime.Now,
                        forumId = subspaceId,
                        userId = subspaceId // Assuming users are distributed evenly
                    });

                    for (int commentId = 1; commentId <= 4; commentId++)
                    {
                        // Create Comment
                        modelBuilder.Entity<Comment>().HasData(new Comment
                        {
                            id = ((subspaceId - 1) * 4 + postId - 1) * 4 + commentId, // Unique Comment ID
                            content = commentContents[(subspaceId - 1) * 4 + commentId - 1], // Different comment for each post
                            creationDate = DateTime.Now,
                            userId = subspaceId, // Again for demonstration
                            postId = (subspaceId - 1) * 4 + postId // Reference to the Post ID
                        });
                    }
                }
            }

        }

    }
}
