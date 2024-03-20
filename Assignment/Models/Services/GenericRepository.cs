﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Assignment.Models.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal ITIContext context;
        internal DbSet<TEntity> dbSet;

        public GenericRepository(ITIContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = ""
            )
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }


        }

        public virtual TEntity? GetById(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Delete(object id)
        {
            TEntity? entityToDelete = dbSet.Find(id);
            if(entityToDelete != null)
                Delete(entityToDelete);

        }

        public virtual void Delete(TEntity entityToDelete)
        {
            /*if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);*/

            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            /*dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;*/
            dbSet.Update(entityToUpdate);
        }

        public virtual void Insert(TEntity entityToAdd)
        {
            dbSet.Add(entityToAdd);
        }
    }
}