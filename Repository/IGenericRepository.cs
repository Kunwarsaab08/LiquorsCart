using System;
using System.Collections.Generic;
using System.Text;
using LiquorsCart.ServerSide.DataModel.DataModels;

namespace LiquorsCart.ServerSide.Repository
{
    public interface IGenericRepository<T> where T : MasterDM, new()    
    {
    }
}
