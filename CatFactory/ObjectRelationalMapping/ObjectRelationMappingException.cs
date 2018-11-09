using System;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents erros for object relational mapping
    /// </summary>
    public class ObjectRelationMappingException : Exception
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ObjectRelationMappingException"/> class
        /// </summary>
        public ObjectRelationMappingException()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ObjectRelationMappingException"/> class
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        public ObjectRelationMappingException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ObjectRelationMappingException"/> class
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified</param>
        public ObjectRelationMappingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
