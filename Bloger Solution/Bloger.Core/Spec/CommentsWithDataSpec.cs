using Bloger.Core.Entities;
using Bloger.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger.Core.Spec
{
    public class CommentsWithDataSpec : BaseSpecification<Comment>
    {
        public CommentsWithDataSpec()
        {
            Includes.Add(C => C.Post);
            Includes.Add(C => C.User);
        }
    }
}
