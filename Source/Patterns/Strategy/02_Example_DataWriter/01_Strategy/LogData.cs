using System;

namespace Strategy._02_Example_DataWriter._01_Strategy
{
    public sealed class LogData
    {
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public bool HasException => Exception != null;
    }
}
