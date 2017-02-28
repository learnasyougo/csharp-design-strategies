using System;

namespace Strategy._02_Example_DataWriter._01_Strategy.LogWriters
{
    /// <summary>
    /// LogWriter that does nothing.
    /// </summary>
    public sealed class NullLogWriter : ILogWriter
    {
        public void Write(LogData logData) { }
    }
}
