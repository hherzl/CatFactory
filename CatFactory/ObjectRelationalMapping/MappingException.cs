using System;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents erros for mapping model
    /// </summary>
    public class MappingException : Exception
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MappingException"/> class
        /// </summary>
        public MappingException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MappingException"/> class
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public MappingException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MappingException"/> class
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        /// <param name="ex">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified</param>
        public MappingException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
