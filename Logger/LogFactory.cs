namespace Logger
{
    public class LogFactory
    {
        private string? FilePath;

        public LogFactory() { }

        public BaseLogger? CreateLogger(string className)
        {
            if (FilePath is not null)
            {
               return new FileLogger
               {
                    PathToFile = FilePath,
                    ClassName = className,
               };
            }
            return null;
        }

        public void ConfigureFileLogger(string filePath)
        {
            FilePath = filePath;
        }

    }
}
