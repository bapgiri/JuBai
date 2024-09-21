namespace JuBai.Models
{
    public class Media
    {
        public int Id { get; set; } // Primary Key
        public string Url { get; set; } = string.Empty; // URL of the media file
        public int PostId { get; set; } // Foreign Key for the Post
        public Post? Post { get; set; } // Navigation property
        public MediaType Type { get; set; } // Type of media (Image, Video, etc.)
        public DateTime CreatedAt { get; set; } // Date when media was uploaded
    }

    public enum MediaType
    {
        Image,
        Video
    }
}
