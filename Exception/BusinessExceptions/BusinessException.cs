using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LiquorsCart.ServerSide.Exceptions.BusinessExceptions
{
    [Serializable]
    public class BusinessException : Exception
    {
        public BusinessException()
        {

        }

        public BusinessException(string message)
            :base(message)
        {

        }

        public BusinessException(string message, Exception innerexception)
            :base(message,innerexception)
        {

        }

        public BusinessException(SerializationInfo info, StreamingContext context)
             : base(info, context)
        {

        }
    }
}
