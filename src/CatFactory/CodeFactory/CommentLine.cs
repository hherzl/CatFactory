using System;

namespace CatFactory.CodeFactory
{
    public class CommentLine : Line, ILine
    {
        public CommentLine()
            : base()
        {
        }

        public CommentLine(Int32 indent, String content, params String[] values)
            : base(indent, content, values)
        {
        }

        public CommentLine(String content, params String[] values)
            : base(content, values)
        {
        }

        public override String ToString()
            => Content;
    }
}
