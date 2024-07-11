using Bloger.Core.Entities;

namespace Bloger.DTO
{
    public class CommentDTO
    {
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public List<int> Postid { get; set; }
        public List<int> Userid { get; set; }
    }
}
