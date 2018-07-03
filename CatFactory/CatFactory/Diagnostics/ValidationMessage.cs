using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace CatFactory.Diagnostics
{
    /// <summary>
    /// Represents a validation message for a validation result
    /// </summary>
    [DebuggerDisplay("LogLevel={LogLevel}, Message={Message}")]
    public class ValidationMessage
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ValidationMessage"/> class
        /// </summary>
        public ValidationMessage()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ValidationMessage"/> class
        /// </summary>
        /// <param name="logLevel">Log level</param>
        /// <param name="message">Message</param>
        public ValidationMessage(LogLevel logLevel, string message)
        {
            LogLevel = logLevel;
            Message = message;
        }

        /// <summary>
        /// Gets or sets the log level
        /// </summary>
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Gets or sets the message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        /// <returns>A string that represents the current object</returns>
        public override string ToString()
            => string.Format("{0}: {1}", LogLevel, Message);
    }
}
