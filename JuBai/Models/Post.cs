using System.Xml.Linq;

namespace JuBai.Models
{
    public class Post
    {
        public int Id { get; set; } // Primary Key
        public string? Title { get; set; } // Title of the post
        public string? Content { get; set; } // Body of the post
        public string? Author { get; set; } // Author's name
                                            //public string? Category { get; set; } // Category (e.g., Social Media, Music, etc.)
                                            // Foreign key for Category
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public Category? Category { get; set; }

        // Foreign key for Tag (if needed)
        public int? TagId { get; set; }
        public Tag? Tag { get; set; }
        public DateTime CreatedAt { get; set; } // Date when post was created
        public DateTime? UpdatedAt { get; set; } // Date when post was updated (nullable)
        public bool IsPublished { get; set; } // Publish status
        public string? ImageUrl { get; set; } // Optional: URL to the featured image
        public int Likes { get; set; } // Number of like
        public ICollection<PostTag> PostTags { get; set; } = new List<PostTag>();
        public List<Media> Media { get; set; } = new List<Media>();
        public List<Like> LikesList { get; set; } = new List<Like>();

        // Constructor
        public Post()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
