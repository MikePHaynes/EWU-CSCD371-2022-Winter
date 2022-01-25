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
            return null;
        }

        public void ConfigureFileLogger(string filePath)
        {
            FilePath = filePath;
        }

    }
}
