using System;
using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private string FilePath { get; set; }
        private string? ClassName { get; set; }

        public FileLogger(string filePath, string? className)
        {
            FilePath = filePath;
            ClassName = className;
        }

        public override void Log(LogLevel logLevel, string message)
        {
            if (File.Exists(FilePath))
            {
                string logMessage = DateTime.Now.ToString() + " " + nameof(ClassName) + " " + logLevel + ": " + message + "\n";
                using StreamWriter sw = File.AppendText(FilePath);
                sw.WriteLine(logMessage);
                sw.Close();
            }
        }

    }
}
