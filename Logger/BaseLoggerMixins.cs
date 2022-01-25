using System;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null)
                throw new ArgumentNullException("BaseLogger parameter is null.");
        }
        
        public static void Warning(BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null)
                throw new ArgumentNullException("BaseLogger parameter is null.");
        }

        public static void Information(BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null)
                throw new ArgumentNullException("BaseLogger parameter is null.");
        }

        public static void Debug(BaseLogger? baseLogger, string message, params object[] arguments)
        {
            if (baseLogger is null)
                throw new ArgumentNullException("BaseLogger parameter is null.");
        }

    }
}
