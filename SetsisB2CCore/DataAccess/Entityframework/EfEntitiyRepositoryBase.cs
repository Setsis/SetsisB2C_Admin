using Microsoft.EntityFrameworkCore;
using SetsisB2C_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SetsisB2C_Core.DataAccess.Entityframework
{
    public class EfEntitiyRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (var context=new TContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context=new TContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public IList<TEntity> List(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context=new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context=new TContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
            }
        }
    }
}
