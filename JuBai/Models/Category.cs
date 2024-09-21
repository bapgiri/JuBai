
namespace JuBai.Models
{
    public class Category
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty; // Name of the category
        public string Description { get; set; } = string.Empty; // Description of the category

        // Navigation prop
        public ICollection<Post>? Posts { get; set; } // Collection of posts

        //public List<Post> Posts { get; set; } = new List<Post>();

        public static implicit operator Category(string CategoryName)
        {
            return new Category { Name = CategoryName };
        }
    }
}
