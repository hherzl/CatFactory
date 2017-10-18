using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.Diagnostics
{
    [DebuggerDisplay("LogLevel={LogLevel}, Message={Message}")]
    public class ValidationMessage
    {
        public ValidationMessage()
        {
        }

        public ValidationMessage(LogLevel logLevel, string message)
        {
            LogLevel = logLevel;
            Message = message;
        }

        public LogLevel LogLevel { get; set; }

        public string Message { get; set; }

        public override string ToString()
            => string.Format("{0}: {1}", LogLevel, Message);
    }
}
