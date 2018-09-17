using System;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class CodeFactoryException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public CodeFactoryException()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public CodeFactoryException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public CodeFactoryException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
