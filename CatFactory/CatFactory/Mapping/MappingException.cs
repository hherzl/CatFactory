using System;

namespace CatFactory.Mapping
{
    public class MappingException : Exception
    {
        public MappingException()
            : base()
        {
        }

        public MappingException(string message)
            : base(message)
        {
        }

        public MappingException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
