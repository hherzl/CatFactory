using System;
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

        public ValidationMessage(LogLevel logLevel, String message)
        {
            LogLevel = logLevel;
            Message = message;
        }

        public LogLevel LogLevel { get; set; }

        public String Message { get; set; }

        public override String ToString()
            => String.Format("{0}: {1}", LogLevel, Message);
    }
}
