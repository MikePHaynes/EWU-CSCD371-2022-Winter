namespace Logger
{
    public class LogFactory
    {
        private string? FilePath { get; set; }
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
