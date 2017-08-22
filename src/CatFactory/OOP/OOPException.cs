using System;

namespace CatFactory.OOP
{
    public class OOPException : Exception
    {
        public OOPException()
            : base()
        {
        }

        public OOPException(String message)
            : base(message)
        {
        }

        public OOPException(String message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
