namespace JuBai.Models
{
    public class PostTag
    {
        public int PostId { get; set; } // Foreign Key for the Post
        public Post? Post { get; set; } // Navigation property

        public int TagId { get; set; } // Foreign Key for the Tag
        public Tag? Tag { get; set; } // Navigation property
    }
}
