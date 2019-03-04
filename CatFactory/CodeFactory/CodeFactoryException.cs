using System;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents errors that occur during scaffolding
    /// </summary>
    public class CodeFactoryException : Exception
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CodeFactoryException"/> class
        /// </summary>
        public CodeFactoryException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeFactoryException"/> class with a specified error message
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public CodeFactoryException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeFactoryException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public CodeFactoryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
