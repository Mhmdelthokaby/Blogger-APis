using Bloger.Core.Entities;
using Bloger.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger.Core
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(string id);
        public Task<int> DeleteAsync(int id);
        public Task<int> UpdateAsync(T entity);

        public Task<IEnumerable<T>> GetAllWithSpecAsync(ISpecification<T> Spec);
        public Task<T> GetByIdWithSpecAsync(ISpecification<T> Spec);

    }
}
