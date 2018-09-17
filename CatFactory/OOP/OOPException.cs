using System;

namespace CatFactory.OOP
{
    /// <summary>
    /// 
    /// </summary>
    public class OOPException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public OOPException()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public OOPException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public OOPException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
