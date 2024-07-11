using Bloger.Core.Entities;
using Bloger.Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger.Repository
{
    public class SpecificationEvalutor<T> where T : BaseEntity
    {
        public static IQueryable<T> GetQuary(IQueryable<T> inputQuary, ISpecification<T> SPec)
        {
            //build Quary


            var Quary = inputQuary; //_dbContext.Set<T>()

            if (SPec.Criteria is not null) // p => p.Id==Id
            {
                Quary = Quary.Where(SPec.Criteria); //_dbContext.Set<T>().Where(p=>p.id == Id)
            }

            //P =>P.ProductBrand , =>P.ProductType

            Quary = SPec.Includes.Aggregate(Quary, (CurrentQuary, IncludeEx) => CurrentQuary.Include(IncludeEx));

            return Quary;
        }
    }
}
