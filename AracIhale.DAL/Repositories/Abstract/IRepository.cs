using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(object id);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        TEntity Add(TEntity entity);
        List<TEntity> AddRange(List<TEntity> entities);
        void Remove(object id);
        void SoftRemove(TEntity entity);
        void RemoveRange(List<TEntity> entities);
        void Update(TEntity entity);
        void UpdateWithId(object id, TEntity entity);
        int GetCount();
    }
}
