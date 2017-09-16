using System;
using System.Diagnostics;

namespace CatFactory.CodeFactory
{
    [DebuggerDisplay("Content={Content}")]
    public class Line : ILine
    {
        public Line()
        {
        }

        public Line(Int32 indent, String content, params String[] values)
        {
            Indent = indent;
            Content = values == null || values.Length == 0 ? content : String.Format(content, values);
        }

        public Line(String content, params String[] values)
        {
            Content = content;
            Content = values == null || values.Length == 0 ? content : String.Format(content, values);
        }

        public Int32 Indent { get; protected set; }

        public String Content { get; protected set; }

        public Boolean IsNullOrEmpty
            => String.IsNullOrEmpty(Content);
    }
}
