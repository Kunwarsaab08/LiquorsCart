using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace LiquorsCart.ServerSide.Exceptions
{
    public class ProcessException : Exception, ISerializable
    {
        public void Process(Exception ex)
        {
        }
    }
}
