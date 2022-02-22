using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression).ToList();
        }

        public TEntity GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        public int GetCount()
        {
            return GetAll().Count;
        }

        public void Remove(object id)
        {
            _dbSet.Remove(GetByID(id));
        }

        public void RemoveRange(List<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;  
        }
        public void UpdateWithId(object id, TEntity entity)
        {
            var existingEntity = this.GetByID(id);
            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
        }

        public TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Added;
            return _dbSet.Add(entity);
        }

        public List<TEntity> AddRange(List<TEntity> entities)
        {
            return _dbSet.AddRange(entities).ToList();
        }

        public void SoftRemove(TEntity entity)
        {
            entity.GetType().GetProperty("IsActive").SetValue(entity, false);
            Update(entity);
        }
    }
}
