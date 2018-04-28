using System;

namespace CatFactory.CodeFactory
{
    public class CodeFactoryException : Exception
    {
        public CodeFactoryException()
            : base()
        {
        }

        public CodeFactoryException(string message)
            : base(message)
        {
        }

        public CodeFactoryException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
