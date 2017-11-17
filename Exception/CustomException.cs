using System;
using System.Diagnostics;
using System.Reflection;

namespace LiquorsCart.ServerSide.Exceptions
{
    [Serializable]
    public class CustomException
    {
        public bool ExceptionOccured { get; set; }
        public Type ExceptionType { get; set; }
        public string ExceptionFileName { get; set; }
        public MethodBase ExceptionMethodName { get; set; }
        public int ExceptionLineNo { get; set; }
        public string ExceptionMessage { get; set; }
        public Exception ExceptionInnerException { get; set; }
        public Exception ExceptionObject { get; set; }
        public string ExceptionTrace { get; set; }

        public CustomException(Exception ex)
        {
            if(!ExceptionOccured)
            {
                ExceptionType = ex.GetType();
                StackTrace st = new StackTrace(ex, true);
                ExceptionFileName = st.GetFrame(0).GetFileName();
                ExceptionMethodName = st.GetFrame(0).GetMethod();
                ExceptionLineNo = st.GetFrame(0).GetFileLineNumber();
                ExceptionMessage = ex.Message;
                ExceptionInnerException = ex.InnerException;
                ExceptionObject = ex;
                ExceptionTrace = ex.StackTrace;
                ExceptionOccured = true;
            }            
        }
    }
}
