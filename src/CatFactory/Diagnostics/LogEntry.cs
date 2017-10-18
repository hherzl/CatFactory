using Microsoft.Extensions.Logging;

namespace CatFactory.Diagnostics
{
    public class LogEntry
    {
        public LogEntry()
        {
        }

        public LogLevel LogLevel { get; set; }

        public string Message { get; set; }
    }
}
