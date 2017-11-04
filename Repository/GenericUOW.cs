using System;
using System.Collections.Generic;
using System.Text;
using DataModel.DataModels;

namespace Repository
{
    public class GenericUOW : IDisposable
    {
        private readonly GenericDBcontext context;
        private bool disposed;
        private Dictionary<string, object> repositories;

        public GenericUOW(GenericDBcontext context)
        {
            this.context = context;
        }

        public GenericUOW()
        {
            context = new GenericDBcontext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public GenericRepository<T> GenericRepository<T>() where T : MasterDM, new()
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repositoryInstance);
            }
            return (GenericRepository<T>)repositories[type];
        }
    }
}
