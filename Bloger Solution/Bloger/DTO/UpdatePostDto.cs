namespace Bloger.DTO
{
    public class UpdatePostDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }

    }
}
