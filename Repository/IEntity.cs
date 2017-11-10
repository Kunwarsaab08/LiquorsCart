using System;
using System.Collections.Generic;
using System.Text;

namespace LiquorsCart.ServerSide.Repository
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
