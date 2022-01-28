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
            string logMessage = DateTime.Now.ToString() + " " + ClassName + " " + logLevel + ": " + message + "\n";
            if (File.Exists(PathToFile))
            {
                using StreamWriter sw = File.AppendText(PathToFile);
                sw.Write(logMessage);
                sw.Close();
            }
            else
            {
                using StreamWriter sw = File.CreateText(PathToFile);
                sw.Write(logMessage);
                sw.Close();
            }
        }

    }
}
