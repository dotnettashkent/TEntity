using System.Linq.Expressions;

namespace TEntity.DAL.IRepositories
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(TEntity entity);
        Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression = null, string[] includes = null);
        IQueryable<TEntity> SelectAllAsync(Expression<Func<TEntity, bool>>expression = null, string[] includes = null);
        Task SaveChangesAsync();
    }
}
