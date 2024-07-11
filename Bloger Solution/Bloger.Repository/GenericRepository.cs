using Bloger.Core;
using Bloger.Core.Entities;
using Bloger.Core.Specifications;
using Bloger.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloger.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly BlogDbContext _dbContext;

        public GenericRepository(BlogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #region Without Specification
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<int> DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _dbContext.Set<T>().Remove(entity);
                return await _dbContext.SaveChangesAsync();
            }
            return 0;
        }
        public async Task<int> UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            return await _dbContext.SaveChangesAsync();
        }
        #endregion


        #region With Specification


        public async Task<IEnumerable<T>> GetAllWithSpecAsync(ISpecification<T> Spec)
        {
            return await ApplySpec(Spec).ToListAsync();
        }

        public async Task<T> GetByIdWithSpecAsync(ISpecification<T> Spec)
        {
            return await ApplySpec(Spec).FirstOrDefaultAsync();
        }

        private IQueryable<T> ApplySpec(ISpecification<T> Spec)
        {
            return SpecificationEvalutor<T>.GetQuary(_dbContext.Set<T>(), Spec);
        }

        


        #endregion

    }
}
