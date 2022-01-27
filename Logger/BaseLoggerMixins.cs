using System;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null) throw new ArgumentNullException(nameof(baseLogger));
            
            string messageWithArguments = String.Format(message, arguments);
            baseLogger.Log(LogLevel.Error, messageWithArguments);
        }
        
        public static void Warning(this BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null) throw new ArgumentNullException(nameof(baseLogger));

            string messageWithArguments = String.Format(message, arguments);
            baseLogger.Log(LogLevel.Warning, messageWithArguments);
        }

        public static void Information(this BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null) throw new ArgumentNullException(nameof(baseLogger));

            string messageWithArguments = String.Format(message, arguments);
            baseLogger.Log(LogLevel.Information, messageWithArguments);
        }

        public static void Debug(this BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null) throw new ArgumentNullException(nameof(baseLogger));

            string messageWithArguments = String.Format(message, arguments);
            baseLogger.Log(LogLevel.Debug, messageWithArguments);
        }

    }
}
