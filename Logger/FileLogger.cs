using System;
using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public string? PathToFile { get; set; }

        public FileLogger() { }

        public FileLogger(string? pathToFile)
        {
            PathToFile = pathToFile;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            if (File.Exists(PathToFile))
            {
                string logMessage = DateTime.Now.ToString() + " " + ClassName + " " + logLevel + ": " + message;
                using StreamWriter sw = File.AppendText(PathToFile);
                sw.WriteLine(logMessage);
                sw.Close();
            }
        }

    }
}
