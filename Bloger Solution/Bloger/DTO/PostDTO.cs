using Bloger.Core.Entities;

namespace Bloger.DTO
{
    public class PostDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<int> CommentIds { get; set; }
        public List<int> PostTagIds { get; set; }
        public List<int> PostReactionIds { get; set; }
    }
}
