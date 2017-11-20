using System;
using System.Collections.Generic;
using DM = LiquorsCart.ServerSide.DataModel.Context;
using LiquorsCart.ServerSide.Exceptions;
using LiquorsCart.ServerSide.Exceptions.DatabaseExceptions;

namespace LiquorsCart.ServerSide.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly DM.GenericDBcontext _context;
        //private IGenericRepository<TEntity> _modelRepository;
        private Dictionary<string, object> repositories;

        public UnitOfWork(DM.GenericDBcontext context) => _context = context;

        public UnitOfWork() => _context = new DM.GenericDBcontext();

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
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
                throw databaseException;
            }            
        }

        //public IGenericRepository<TEntity> ModelRepository
        //{
        //    get { return _modelRepository ?? (_modelRepository = new GenericRepository<TEntity>(_context)); }
        //}

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                DatabaseException databaseException = new DatabaseException();
                databaseException.Data.Add("CustomException", new CustomException(ex));
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
    }
}
