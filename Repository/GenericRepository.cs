using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using LiquorsCart.ServerSide.Exceptions;
using LiquorsCart.ServerSide.Exceptions.DatabaseExceptions;
using System.Diagnostics;

namespace LiquorsCart.ServerSide.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbContext context;
        private DbSet<TEntity> dbSet;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();            
        }

        public virtual List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includes)
        {
            try
            {
                IQueryable<TEntity> query = dbSet;

                foreach (Expression<Func<TEntity, object>> include in includes)
                    query = query.Include(include);

                if (filter != null)
                    query = query.Where(filter);

                if (orderBy != null)    
                    query = orderBy(query);

                return query.ToList();
            }
            catch(Exception ex)
            {
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
                throw databaseException;
            }            
        }

        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            try
            {
                IQueryable<TEntity> query = dbSet;

                if (filter != null)
                    query = query.Where(filter);

                if (orderBy != null)
                    query = orderBy(query);

                return query;
            }
            catch (Exception ex)
            {
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
                throw databaseException;
            }
        }

        public virtual TEntity GetById(object id)
        {
            try
            {
                return dbSet.Find(id);
            }
            catch (Exception ex)
            {
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
                throw databaseException;
            }            
        }

        public virtual TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            try
            {
                IQueryable<TEntity> query = dbSet;

                foreach (Expression<Func<TEntity, object>> include in includes)
                    query = query.Include(include);

                return query.FirstOrDefault(filter);
            }
            catch (Exception ex)
            {
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
                throw databaseException;
            }            
        }

        public virtual void Insert(TEntity entity)
        {
            try
            {
                dbSet.Add(entity);
            }
            catch (Exception ex)
            {
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
                throw databaseException;
            }            
        }

        public virtual void Update(TEntity entity)
        {
            try
            {
                dbSet.Attach(entity);
                context.Entry(entity).State = EntityState.Modified;
            }
            catch(Exception ex)
            {
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
                throw databaseException;
            }
            
        }

        public virtual void Delete(object id)
        {
            try
            {
                TEntity entityToDelete = dbSet.Find(id);
                if (context.Entry(entityToDelete).State == EntityState.Detached)
                {
                    dbSet.Attach(entityToDelete);
                }
                dbSet.Remove(entityToDelete);
            }
            catch(Exception ex)
            {
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
                throw databaseException;
            }            
        }
    }
}
