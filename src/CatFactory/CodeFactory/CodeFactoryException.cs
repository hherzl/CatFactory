using System;

namespace CatFactory.CodeFactory
{
    public class CodeFactoryException : Exception
    {
        public CodeFactoryException()
            : base()
        {
        }

        public CodeFactoryException(String message)
            : base(message)
        {
        }

        public CodeFactoryException(String message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
