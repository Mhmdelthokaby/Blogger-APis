using Bloger.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bloger.Core.Specifications
{
    public interface ISpecification<T> where T : BaseEntity
    {


        //Sign For Preporty For "Where"
        public Expression<Func<T, bool>> Criteria { get; set; }

        //sign For Property for List of Includees 
        public List<Expression<Func<T, object>>> Includes { get; set; }

    }
}
