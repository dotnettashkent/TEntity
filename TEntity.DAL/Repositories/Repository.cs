using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TEntity.DAL.Contexts;
using TEntity.DAL.IRepositories;
using TEntity.Domain.Commons;

namespace TEntity.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private readonly AppDbContext dbContext;

        private readonly DbSet<TEntity> dbSet;
        public Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = dbContext.Set<TEntity>();
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            var result = await this.dbSet.FirstOrDefaultAsync(t => t.Id == entity.Id);
            if (result is not null)
            {
                result.IsDeleted = true;
                return true;
            }
            return false;
        }

        public IQueryable<TEntity> SelectAllAsync(Expression<Func<TEntity, bool>> expression = null, string[] includes = null)
        {
            var query = expression is null ? this.dbSet: this.dbSet.Where(expression);
            if (includes is not null)
            {
                foreach(var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query;
        }

        public async Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression = null, string[] includes = null)
            => await this.SelectAllAsync(expression, includes).FirstOrDefaultAsync();

        public async Task<TEntity> InsertAsync(TEntity entity)
            => (await this.dbSet.AddAsync(entity)).Entity;

        public async Task SaveChangesAsync()
            => await this.dbContext.SaveChangesAsync();

        public async Task<TEntity> UpdateAsync(TEntity entity)
            => (this.dbSet.Update(entity)).Entity;
    }
}
