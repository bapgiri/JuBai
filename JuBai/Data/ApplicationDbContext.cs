using JuBai.Models;
using Microsoft.EntityFrameworkCore;

namespace JuBai.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; } // DbSet for Post model
        public DbSet<Category> Categories { get; set; } // DbSet for Category model
        public DbSet<Tag> Tags { get; set; } // DbSet for Tag model
        public DbSet<PostTag> PostTags { get; set; } // DbSet for PostTag model
        public DbSet<Like> Likes { get; set; } // DbSet for Like model
        public DbSet<Media> Media { get; set; } // DbSet for Media model
        public DbSet<User> Users { get; set; } // DbSet for User model

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the many-to-many relationship between Post and Tag
            modelBuilder.Entity<PostTag>()
        .HasKey(pt => new { pt.PostId, pt.TagId });

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(pt => pt.PostId);

            modelBuilder.Entity<PostTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.PostTags)
                .HasForeignKey(pt => pt.TagId);


            // One-to-many relationship between Post and Media
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Media)
                .WithOne(m => m.Post)
                .HasForeignKey(m => m.PostId);

            // One-to-many relationship between Post and Like
            modelBuilder.Entity<Post>()
                .HasMany(p => p.LikesList)
                .WithOne(l => l.Post)
                .HasForeignKey(l => l.PostId);


            // One-to-many relationship between User and Like
            modelBuilder.Entity<User>()
                .HasMany(u => u.Likes)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId);

            // 1. Seed Users (UserId = 1)
            modelBuilder.Entity<User>().HasData(
    new User { Id = 1, Name = "John Doe", Username = "johndoe", Email = "johndoe@example.com" }
);


            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Music" },
                new Category { Id = 2, Name = "Politics" },
                new Category { Id = 3, Name = "Sports" },
                new Category { Id = 4, Name = "Fashion" },
                new Category { Id = 5, Name = "Entertainment" }
            );


            // 2. Seed Posts (PostId = 1)
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    Title = "First Post",
                    Content = "This is the content of the first post.",
                    Author = "admin",
                    CategoryId = 1, // Provide the foreign key value (not the navigation property)
                    CreatedAt = DateTime.Now,
                    IsPublished = true
                }
            );

            // Seed Tags
            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "Trending" },
                new Tag { Id = 2, Name = "New Release" },
                new Tag { Id = 3, Name = "Event" }
            );





            // Seed Media
            modelBuilder.Entity<Media>().HasData(
                new Media
                {
                    Id = 1,
                    Url = "http://example.com/image.jpg",
                    PostId = 1, // References the seeded Post with Id = 1
                    Type = MediaType.Image,
                    CreatedAt = DateTime.Now
                }
            );

            // Seed Likes
            modelBuilder.Entity<Like>().HasData(
                new Like
                {
                    Id = 1,
                    PostId = 1, // References the seeded Post with Id = 1
                    UserId = 1, // References the seeded User with Id = 1
                    CreatedAt = DateTime.Now
                }
            );

            // Seed PostTags
            modelBuilder.Entity<PostTag>().HasData(
                new PostTag { PostId = 1, TagId = 1 } // References the seeded Post with Id = 1 and Tag with Id = 1
            );
        }
    }
}
