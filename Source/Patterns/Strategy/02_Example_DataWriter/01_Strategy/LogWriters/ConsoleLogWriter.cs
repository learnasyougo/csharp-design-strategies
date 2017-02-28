using System;

namespace Strategy._02_Example_DataWriter._01_Strategy.LogWriters
{
    /// <summary>
    /// LogWriter that writes to stdout / console
    /// </summary>
    public sealed class ConsoleLogWriter : ILogWriter
    {
        public void Write(LogData logData) {
            if (logData.HasException) {
                Console.WriteLine($"ERR: {logData.Message} ({logData.Exception.Message}).");
            }
            else {
                Console.WriteLine(logData.Message);
            }
        }
    }
}
