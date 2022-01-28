using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void Log_ValidPathFileDoesNotExist_CreatesFileAndLogsMessage()
        {
            string path = @"testfile.txt";
            var logger = new FileLogger()
            {
                PathToFile = path,
                ClassName = nameof(FileLoggerTests)
            };
           
            logger.Log(LogLevel.Warning, "Test message");
            string expectedLogMessage = $"{DateTime.Now} {nameof(FileLoggerTests)} {LogLevel.Warning}: Test message\n";
            string actualLogMessage = File.ReadAllText(path);
            File.Delete(path);
            Assert.AreEqual(expectedLogMessage, actualLogMessage);
        }

    }
}
