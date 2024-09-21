namespace JuBai.Models
{
    public class Like
    {
        public int Id { get; set; } // Primary Key
        public int PostId { get; set; } // Foreign Key for the Post
        public Post? Post { get; set; } // Navigation property

        public int UserId { get; set; } // Foreign Key for the User
        public User? User { get; set; } // Navigation property
        public DateTime CreatedAt { get; set; } // Date when the like was given
    }
}
