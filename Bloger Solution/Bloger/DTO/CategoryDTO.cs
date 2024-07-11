using Bloger.Core.Entities;

namespace Bloger.DTO
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<int> PostsId { get; set; }

    }
}
