using System;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents errors that occur during application execution
    /// </summary>
    public class ObjectOrientedProgrammingException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectOrientedProgrammingException"/> class
        /// </summary>
        public ObjectOrientedProgrammingException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectOrientedProgrammingException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public ObjectOrientedProgrammingException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectOrientedProgrammingException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public ObjectOrientedProgrammingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
