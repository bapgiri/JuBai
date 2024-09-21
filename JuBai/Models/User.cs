namespace JuBai.Models
{
    public class User
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty; // Username for the user
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty; // Email address
        public string PasswordHash { get; set; } = string.Empty; // Hashed password
        public string Role { get; set; } = "Reader"; // User role (Admin, Author, Reader)
        public DateTime CreatedAt { get; set; } // Date when the user account was created
        public string? ProfilePictureUrl { get; set; } // Optional: URL to the user's profile picture

        // Navigation properties
        public List<Like> Likes { get; set; } = new List<Like>(); // List of likes given by the user
        
    }
}
