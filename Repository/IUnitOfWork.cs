using System;
using System.Collections.Generic;
using System.Text;
using LiquorsCart.ServerSide.DataModel.DataModels.Inventory;

namespace LiquorsCart.ServerSide.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
