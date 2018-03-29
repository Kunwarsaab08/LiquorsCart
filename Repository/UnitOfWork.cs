using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using CustomExceptions = LiquorsCart.ServerSide.Exceptions;

namespace LiquorsCart.ServerSide.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly GenericDBcontext _context;
        
        private Dictionary<string, object> repositories;

        public UnitOfWork(GenericDBcontext context) => _context = context;

        public UnitOfWork() => _context = new GenericDBcontext();

        public GenericRepository<T> GenericRepository<T>() where T : class
        {
            try
            {
                if (repositories == null)
                {
                    repositories = new Dictionary<string, object>();
                }

                var type = typeof(T).Name;

                if (!repositories.ContainsKey(type))
                {
                    var repositoryType = typeof(GenericRepository<>);
                    var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
                    repositories.Add(type, repositoryInstance);
                }
                return (GenericRepository<T>)repositories[type];
            }
            catch(Exception ex)
            {
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
                throw databaseException;
            }            
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                CustomExceptions.DatabaseExceptions.DatabaseException databaseException = new CustomExceptions.DatabaseExceptions.DatabaseException();
                databaseException.Data.Add("CustomException", new CustomExceptions.CustomException(ex));
                throw databaseException;
            }            
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        public void BeginTransaction(DbContext context)
        {
            if(context.Database.CurrentTransaction == null)
            {
                context.Database.BeginTransaction();
            }
        }

        public void CommitTransaction(DbContext context)
        {
            if(context.Database.CurrentTransaction != null)
            {
                context.Database.CommitTransaction();
            }
        }

        public void RollBackTransaction(DbContext context)
        {
            if (context.Database.CurrentTransaction != null)
            {
                context.Database.RollbackTransaction();
            }
        }
    }
}
