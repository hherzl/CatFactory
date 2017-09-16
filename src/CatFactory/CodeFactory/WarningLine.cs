using System;

namespace CatFactory.CodeFactory
{
    public class WarningLine : Line, ILine
    {
        public WarningLine()
            : base()
        {
        }

        public WarningLine(Int32 indent, String content, params String[] values)
            : base(indent, content, values)
        {
        }

        public WarningLine(String content, params String[] values)
            : base(content, values)
        {
        }

        public override String ToString()
            => Content;
    }
}
