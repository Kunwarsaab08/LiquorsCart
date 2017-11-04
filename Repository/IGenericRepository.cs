using System;
using System.Collections.Generic;
using System.Text;
using DataModel.DataModels;

namespace Repository
{
    public interface IGenericRepository<T> where T : MasterDM, new()    
    {
    }
}
