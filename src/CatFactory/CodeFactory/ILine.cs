using System;

namespace CatFactory.CodeFactory
{
    public interface ILine
    {
        Int32 Indent { get; }

        String Content { get; }

        Boolean IsNullOrEmpty { get; }
    }
}
