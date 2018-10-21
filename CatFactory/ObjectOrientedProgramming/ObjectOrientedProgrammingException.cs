using System;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    public class ObjectOrientedProgrammingException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public ObjectOrientedProgrammingException()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public ObjectOrientedProgrammingException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ObjectOrientedProgrammingException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
