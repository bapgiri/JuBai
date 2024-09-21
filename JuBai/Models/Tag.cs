namespace JuBai.Models
{
    public class Tag
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty; // Name of the tag

        // Navigation property
        public List<PostTag> PostTags { get; set; } = new List<PostTag>(); // List of post-tag relationships
    }
}
