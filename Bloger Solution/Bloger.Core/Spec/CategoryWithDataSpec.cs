using Bloger.Core.Entities;
using Bloger.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger.Core.Spec
{
    public class CategoryWithDataSpec :BaseSpecification<Category>
    {
        public CategoryWithDataSpec()
        {
            Includes.Add(C => C.Posts);
        }

        public CategoryWithDataSpec(int id):base(d =>d.Id ==id)
        {
            Includes.Add(C => C.Posts);
        }
    }
}
