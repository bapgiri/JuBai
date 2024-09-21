namespace JuBai.ViewModels
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int? TagId { get; set; } // Make TagId nullable
        public string? CategoryName { get; set; } // Add this line
        public string? Author { get; set; } // Nullable
        public string? CreatedAt { get; set; } // Nullable
    }
}
