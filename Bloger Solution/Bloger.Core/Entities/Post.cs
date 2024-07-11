using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bloger.Core.Entities
{
    
        public class Post : BaseEntity
        {
            public int UserId { get; set; }
            public int CategoryId { get; set; }
            public string Title { get; set; }
            public string Slug { get; set; }
            public string Content { get; set; }
            public string FeaturedImageUrl { get; set; }
            public string Status { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public DateTime? PublishedAt { get; set; }

            // Navigation properties
            public User User { get; set; }
            public Category Category { get; set; }
            public ICollection<Comment> Comments { get; set; }
            public ICollection<PostTag> PostTags { get; set; }
            public ICollection<PostReaction> PostReactions { get; set; }
        }
    

}
