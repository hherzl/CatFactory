using System;

namespace CatFactory.Mapping
{
    public class MappingException : Exception
    {
        public MappingException()
            : base()
        {
        }

        public MappingException(String message)
            : base(message)
        {
        }

        public MappingException(String message, Exception ex)
            : base(message, ex)
        {
        }
    }
}
