using System;

namespace CatFactory.CodeFactory
{
    public class TodoLine : Line, ILine
    {
        public TodoLine()
            : base()
        {
        }

        public TodoLine(Int32 indent, String content, params String[] values)
            : base(indent, content, values)
        {
        }

        public TodoLine(String content, params String[] values)
            : base(content, values)
        {
        }

        public override String ToString()
            => Content;
    }
}
