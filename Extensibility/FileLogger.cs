using System;
using System.IO;

namespace Extensibility
{
    public class FileLogger : ILogger
    {
        private string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }

        public void LogError(string message)
        {
            Log(message, "Error");
        }

        public void LogInfo(string message)
        {
            Log(message, "Info");
        }

        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
                //使用 using，complier 會自動執行 Dispose 釋放資源
                //streamWriter.Dispose();
            }
        }
    }
}