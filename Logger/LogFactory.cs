namespace Logger
{
    public class LogFactory
    {
        private string? ClassName { get; set; }
        private string? FilePath { get; set; }

        public LogFactory(string className)
        {
            ClassName = className;
        }

        public BaseLogger? CreateLogger(string className)
        {
            if (FilePath is not null) return new FileLogger(FilePath, ClassName);
            return null;
        }

        public void ConfigureFileLogger(string filePath)
        {
            FilePath = filePath;
        }

    }
}
