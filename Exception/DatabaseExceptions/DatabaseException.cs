using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LiquorsCart.ServerSide.Exceptions.DatabaseExceptions
{
    [Serializable]
    public class DatabaseException: Exception
    {        
        public DatabaseException()
            :base()
        {

        }

        public DatabaseException(string message)
            :base(message)
        {

        }

        public DatabaseException(string message, Exception innerexception)
            :base(message,innerexception)
        {

        }

        public DatabaseException(SerializationInfo info, StreamingContext context)
             : base(info, context)
        {

        }
    }
}
