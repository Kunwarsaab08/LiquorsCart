using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LiquorsCart.ServerSide.Exceptions.Mapper
{
    [Serializable]
    public class MappingNotFound: Exception
    {
        public MappingNotFound()
            :base()
        {

        }

        public MappingNotFound(string message)
            :base(message)
        {

        }

        public MappingNotFound(string message, Exception innerExcption)
            :base(message, innerExcption)
        {

        }

        public MappingNotFound(SerializationInfo info, StreamingContext context)
             : base(info, context)
        {

        }
    }
}
