using System;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null)
                throw new ArgumentNullException(nameof(baseLogger));
            
            string messageWithArguments = String.Format(message, arguments);
            baseLogger.Log(LogLevel.Error, messageWithArguments);
        }
        
        public static void Warning(BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null)
                throw new ArgumentNullException(nameof(baseLogger));

            string messageWithArguments = String.Format(message, arguments);
            baseLogger.Log(LogLevel.Warning, messageWithArguments);
        }

        public static void Information(BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null)
                throw new ArgumentNullException(nameof(baseLogger));

            string messageWithArguments = String.Format(message, arguments);
            baseLogger.Log(LogLevel.Information, messageWithArguments);
        }

        public static void Debug(BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null)
                throw new ArgumentNullException(nameof(baseLogger));

            string messageWithArguments = String.Format(message, arguments);
            baseLogger.Log(LogLevel.Debug, messageWithArguments);
        }

    }
}
