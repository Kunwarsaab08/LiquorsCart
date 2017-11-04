using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
