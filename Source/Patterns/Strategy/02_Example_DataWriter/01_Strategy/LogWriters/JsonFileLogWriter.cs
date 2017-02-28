using Newtonsoft.Json;
using System;

namespace Strategy._02_Example_DataWriter._01_Strategy.LogWriters
{

    public class JsonFileLogWriter : ILogWriter
    {
        public void Write(LogData logData) {
            var jsonData = JsonConvert.SerializeObject(logData);
            // implement file writing logic
            // could also be done by using a strategy, such as IWriteJsonDataStrategy
              // -> IFirebaseWriteJsonData
              // -> IAppendFileWriteJsonData
              // etc..
        }
    }
}
