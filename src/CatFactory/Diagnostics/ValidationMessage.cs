using System;
using Microsoft.Extensions.Logging;

namespace CatFactory.Diagnostics
{
    public class ValidationMessage
    {
        public ValidationMessage()
        {
        }

        public ValidationMessage(LogLevel logLevel, String message)
        {
            LogLevel = logLevel;
            Message = message;
        }

        public LogLevel LogLevel { get; set; }

        public String Message { get; set; }
    }
}
