using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
            Task<TEntity> AddAsync(TEntity entity);

            TEntity Update(TEntity entity);

            Task<IReadOnlyList<TEntity>> AllAsync();

            IReadOnlyList<TEntity> Filter(Func<TEntity, bool> predicate);

            TEntity? GetById(int id);

            Task<int> CommitAsync();

            int Commit();
    }
}
