using Core.DataAcccess;
using Core.Entities;
using Core.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{ 
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class ,IEntity , new()
        where TContext : DbContext, new()

    {
        public void Add(TEntity X)
        {
            using (TContext Y = new TContext())
            {
                var addedEntity = Y.Entry(X);
                addedEntity.State = EntityState.Added;
                Y.SaveChanges();
            }
        }

       

        public void Delete(TEntity X)
        {
            using (TContext Y = new TContext())
            {
                var deletedEntity = Y.Entry(X);
                deletedEntity.State = EntityState.Deleted;
                Y.SaveChanges();
            }
        }

      

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext Y = new TContext())
            {
                return Y.Set<TEntity>().SingleOrDefault(filter);
            }
        }
        
      

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext Y = new TContext())
            {
                return filter == null
                    ? Y.Set<TEntity>().ToList()
                    : Y.Set<TEntity>().Where(filter).ToList();
            }

        }

       



        public void Update(TEntity X)
        {
            using (TContext Y = new TContext())
            {
                var uptadedEntity = Y.Entry(X);
                uptadedEntity.State = EntityState.Modified;
                Y.SaveChanges();
            }
        }


}

}