using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Uni.DataLayer.Entities.Common;

namespace Uni.DataLayer.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Queryable(bool asNoTracking = false);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(long id);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Delete(long id);
        void DeleteRange(IEnumerable<TEntity> entities);
        void LogicalDeleteRange(IEnumerable<TEntity> entities);
        void LogicalDelete(TEntity entity);
        void LogicalDelete(long id);
        bool Exists(Expression<Func<TEntity, bool>> predicate);
        bool Exists(long id);
        void SaveChanges();
    }
}
