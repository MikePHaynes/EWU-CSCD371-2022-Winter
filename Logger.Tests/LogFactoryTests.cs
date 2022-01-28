using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void CreateLogger_FileLoggerNotConfigured_ReturnsNull()
        {
            LogFactory logFactory = new();
            var fileLogger = logFactory.CreateLogger(nameof(LogFactoryTests));

            Assert.IsNull(fileLogger);
        }

        [TestMethod]
        public void CreateLogger_FileLoggerConfigured_ReturnsFileLogger()
        {
            LogFactory logFactory = new();
            logFactory.ConfigureFileLogger("testfile.txt");
            var fileLogger = logFactory.CreateLogger(nameof(LogFactoryTests));

            Assert.IsNotNull(fileLogger);
        }
        
    }
}
