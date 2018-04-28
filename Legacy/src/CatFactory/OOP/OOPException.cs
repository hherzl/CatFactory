using System;

namespace CatFactory.OOP
{
    public class OOPException : Exception
    {
        public OOPException()
            : base()
        {
        }

        public OOPException(string message)
            : base(message)
        {
        }

        public OOPException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
