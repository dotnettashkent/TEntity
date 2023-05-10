using TEntity.DAL.IRepositories;
using TEntity.Domain.Commons;

namespace TEntity.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
    }
}
