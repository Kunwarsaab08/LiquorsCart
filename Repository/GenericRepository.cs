using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CustomExceptions = LiquorsCart.ServerSide.Exceptions;
using System.Data.SqlClient;

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
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
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
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
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
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
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
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
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
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
                throw databaseException;
            }            
        }

        public virtual bool IsValidEntity(TEntity entity)
        {
            try
            {
                return dbSet.Any(r => r == entity);
            }
            catch (Exception ex)
            {
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
                throw databaseException;
            }
        }

        public virtual void Update(TEntity entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            catch(Exception ex)
            {
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
                throw databaseException;
            }
            
        }

        public virtual void Delete(object id)
        {
            try
            {
                TEntity entityToDelete = dbSet.Find(id);
                context.Entry(entityToDelete).State = EntityState.Deleted;
            }
            catch(Exception ex)
            {
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
                throw databaseException;
            }            
        }

        //public virtual Int64 GetCurrentIdentity(string tablename)
        //{
        //    try
        //    {
        //        var sql = "SELECT dbo.getCurrentIdentity(@tablename)";
        //        Int64 curr_dentity = Convert.ToInt64(context.Database.ExecuteSqlCommand(sql, new SqlParameter("@tablename", tablename)));
        //        return curr_dentity;
        //    }
        //    catch (Exception ex)
        //    {
        //        CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
        //        databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
        //        throw databaseException;
        //    }            
        //}

        //public virtual Int64 GetNextIdentity(string tablename)
        //{
        //    try
        //    {
        //        var sql = "EXEC dbo.getNextIdentity @tablename";
        //        var outparam = new SqlParameter();
        //        var curr_dentity = context.Database.ExecuteSqlCommand(sql, new SqlParameter("@tablename", tablename));
        //        return curr_dentity;
        //    }
        //    catch (Exception ex)
        //    {
        //        CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
        //        databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
        //        throw databaseException;
        //    }
        //}
    }
}
