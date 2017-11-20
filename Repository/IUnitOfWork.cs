using System;

namespace LiquorsCart.ServerSide.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
