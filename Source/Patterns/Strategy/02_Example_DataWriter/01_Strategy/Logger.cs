using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy._02_Example_DataWriter._01_Strategy
{
    public class Logger
    {
        private readonly IList<ILogWriter> _logWriters;

        public Logger(params ILogWriter[] logWriters) {
            _logWriters = logWriters;
        }
        public Logger(ILogWriter logWriter)
            : this(new ILogWriter[] { logWriter }) {
        }

        public void Log(string message, Exception exception = null) {
            var logData = new LogData {
                Exception = exception,
                Message = message
            };
            _logWriters
                .ToList()
                .ForEach(logWriter => logWriter.Write(logData));
        }
    }
}
