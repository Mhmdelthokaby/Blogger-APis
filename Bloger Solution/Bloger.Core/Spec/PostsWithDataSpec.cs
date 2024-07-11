using Bloger.Core.Entities;
using Bloger.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger.Core.Spec
{
    public class PostsWithDataSpec : BaseSpecification<Post>
    {
        public PostsWithDataSpec() : base()
        {
            Includes.Add(p => p.User);
            Includes.Add(p => p.Category);
            Includes.Add(p => p.Comments);
            Includes.Add(p => p.PostTags);
            Includes.Add(p => p.PostReactions);
        }
        public PostsWithDataSpec(int id) : base(p => p.Id == id)
        {
            Includes.Add(p => p.User);
            Includes.Add(p => p.Category);
            Includes.Add(p => p.Comments);
            Includes.Add(p => p.PostTags);
            Includes.Add(p => p.PostReactions);
        }
    }
}
