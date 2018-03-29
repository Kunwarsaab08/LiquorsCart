using Microsoft.EntityFrameworkCore;
using System;

namespace LiquorsCart.ServerSide.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction(DbContext context);
        void Save();
        void CommitTransaction(DbContext context);
        void RollBackTransaction(DbContext context);
    }
}
